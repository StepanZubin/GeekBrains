import model_mult as model
import view

# Метод Кнопка
def button_click():
    value_a = view.get_value()
    value_b = view.get_value()
    model.init(value_a, value_b)
    result = model.mult()
    view.view_data(result)

















