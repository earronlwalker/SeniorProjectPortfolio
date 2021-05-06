from flask_movies import db

class Top250(db.Model):
    id = db.Column(db.Integer, primary_key=True)
    title = db.Column(db.String(100), nullable=True, unique=False)
    rating = db.Column(db.String(10), nullable=True, unique=False)
    year = db.Column(db.String(10), nullable=True, unique=False)
    votes = db.Column(db.String(20), nullable=True, unique=False)
    rank = db.Column(db.String(10), nullable=True, unique=False)
    cover_url = db.Column(db.String(300), nullable=True, unique=False)

    def __repr__(self):
        return f"{self.title}"


class Popular100(db.Model):
    id = db.Column(db.Integer, primary_key=True)
    title = db.Column(db.String(100), nullable=True, unique=False)
    rating = db.Column(db.String(10), nullable=True, unique=False)
    year = db.Column(db.String(10), nullable=True, unique=False)
    votes = db.Column(db.String(20), nullable=True, unique=False)
    rank = db.Column(db.String(10), nullable=True, unique=False)
    cover_url = db.Column(db.String(300), nullable=True, unique=False)

    def __repr__(self):
        return f"{self.title}"