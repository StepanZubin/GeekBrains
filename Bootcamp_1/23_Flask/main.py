from turtle import title
from flask import Flask, render_template #вытащил объект

app = Flask(__name__)

@app.route('/<name>') #создание главной страницы
def main(name):
    a = 'Stepan'
    return render_template('base.html', name=name, title='BootCamp')

if __name__ == '__main__':
    app.run()