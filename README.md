# Strategy

This code implements the Strategy design pattern in C#. The pattern defines a family of algorithms, encapsulates each one, and makes them interchangeable. The code demonstrates this by defining an abstract PaymentStrategy class that serves as the interface for various payment methods.

Two concrete strategies, CreditCardStrategy and PayPalStrategy, inherit from PaymentStrategy and provide their own implementation of the Pay method. The ShoppingCart class acts as the context for this pattern and holds a reference to a PaymentStrategy object, which it uses to perform the payment. The Main method sets up the shopping cart, sets the amount and payment strategy, and triggers the payment.