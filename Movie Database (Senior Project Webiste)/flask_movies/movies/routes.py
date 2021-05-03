from flask import Blueprint, render_template, redirect, url_for, request
from flask.helpers import flash, url_for
import imdb
from sqlalchemy.sql.expression import delete
from flask_movies import db
from flask_movies.models import Top250, Popular100
ie = imdb.IMDb()

movies = Blueprint('movies',__name__)


@movies.route('/')
def home():
    return render_template('home.html')


@movies.route('/top250')
def top250():
    page = request.args.get('page', 1, type=int)
    movies = Top250.query.paginate(page=page, per_page=10, )
    return render_template('movies_list.html', movies=movies)

@movies.route('/scrape_top250')
def scrape_top250():
    # Deleting all the database table 250 data
    Top250.query.delete()
    # Getting and adding new data to database
    movies = ie.get_top250_movies()
    for movie in movies:
        mymovie = Top250(title=movie['title'], year=movie['year'], 
                         rating=movie['rating'], votes=movie['votes'], 
                         rank=movie['top 250 rank'], cover_url='')

        db.session.add(mymovie)
    db.session.commit()
    flash('Database has been Updated successfully', 'success')
    return redirect(url_for('movies.top250'))

# Movies search functionality
@movies.route('/search', methods=['POST'])
def search():
    query = request.form.get('query')
    movies = ie.search_movie(query)
    return render_template('search_results.html', movies=movies, query=query)


@movies.route('/scrape_popular100')
def scrape_popular100():
    Popular100.query.delete()
    movies = ie.get_popular100_movies()
    for movie in movies:
        mymovie = Popular100(title=movie['title'], year=movie['year'], 
                         rating=movie['rating'], votes=movie['votes'], 
                         rank=movie['popular movies 100 rank'], cover_url='')

        db.session.add(mymovie)
    db.session.commit()
    flash('Database has been Updated successfully', 'success')
    return redirect(url_for('movies.popular100'))

@movies.route('/popular100')
def popular100():
    page = request.args.get('page', 1, type=int)
    movies = Popular100.query.paginate(page=page, per_page=10, )
    return render_template('popular_list.html', movies=movies)

