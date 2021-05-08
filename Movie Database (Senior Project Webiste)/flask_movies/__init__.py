from flask import Flask,redirect,url_for,render_template,request
from flask_sqlalchemy import SQLAlchemy
from flask_migrate import Migrate
from flask_movies.config import Config


db = SQLAlchemy()
migrate = Migrate()

def create_app():
    app=Flask(__name__)
    app.config.from_object(Config)

    db.init_app(app)
    migrate.init_app(app, db)


    from flask_movies.movies.routes import movies
    app.register_blueprint(movies)

    return app
