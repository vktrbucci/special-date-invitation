from django.http import HttpResponse
from django.shortcuts import render

def index(request):
    return HttpResponse("Hello, world! Você vai num encontro comigo.")

# Create your views here.
