import markup as markup
import telebot
from telebot import types

token = '5912536079:AAGlR28LypPT3G3QV_Dm_QI0FjlpCLmFxEQ'
bot = telebot.TeleBot(token)


@bot.message_handler(commands=['start'])
def start_message(message):
    bot.send_message(message.chat.id, "Привет это бот-гороскоп.Если хотите узнать грядущее введите слово /zodiac")


@bot.message_handler(commands=['zodiac'])

def button_message(message):
    markup = types.ReplyKeyboardMarkup(resize_keyboard=True)
    item1 = types.KeyboardButton("Овен")
    item2 = types.KeyboardButton("Телец")
    item3 = types.KeyboardButton("Близнецы")
    item4 = types.KeyboardButton("Рак")
    item5 = types.KeyboardButton("Лев")
    item6 = types.KeyboardButton("Дева")
    item7 = types.KeyboardButton("Весы")
    item8 = types.KeyboardButton("Скорпион")
    item9 = types.KeyboardButton("Стрелец")
    item10 = types.KeyboardButton("Козерог")
    item11 = types.KeyboardButton("Водолей")
    item12 = types.KeyboardButton("Рыбы")
    markup.add(item1, item2, item3, item4, item5, item6, item7, item8, item9, item10, item11, item12)
    bot.send_message(message.chat.id, 'Выберите что вам надо', reply_markup=markup)

@bot.message_handler(content_types=['text'])
def message_reply(message):
    if message.text == "Овен":
        bot.send_message(message.chat.id, "https://horo.mail.ru/prediction/aries/today/")
    if message.text == "Телец":
        bot.send_message(message.chat.id, "https://horo.mail.ru/prediction/taurus/today/")
    if message.text == "Близнецы":
        bot.send_message(message.chat.id, "https://horo.mail.ru/prediction/gemini/today/")
    if message.text == "Рак":
        bot.send_message(message.chat.id, "https://horo.mail.ru/prediction/cancer/today/")
    if message.text == "Лев":
        bot.send_message(message.chat.id, "https://horo.mail.ru/prediction/leo/today/")
    if message.text == "Дева":
        bot.send_message(message.chat.id, "https://horo.mail.ru/prediction/virgo/today/")
    if message.text == "Весы":
        bot.send_message(message.chat.id, "https://horo.mail.ru/prediction/libra/today/")
    if message.text == "Скорпион":
        bot.send_message(message.chat.id, "https://horo.mail.ru/prediction/scorpio/today/")
    if message.text == "Стрелец":
        bot.send_message(message.chat.id, "https://horo.mail.ru/prediction/sagittarius/today/")
    if message.text == "Козерог":
        bot.send_message(message.chat.id, "https://horo.mail.ru/prediction/capricorn/today/")
    if message.text == "Водолей":
        bot.send_message(message.chat.id, "https://horo.mail.ru/prediction/aquarius/today/")
    if message.text == "Рыбы":
        bot.send_message(message.chat.id, "https://horo.mail.ru/prediction/pisces/today/")

bot.infinity_polling()
