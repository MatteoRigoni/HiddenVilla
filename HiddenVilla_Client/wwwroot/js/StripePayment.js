redirectToCheckout = function (sessionId) {
    var stripe = Stripe('pk_test_51JKlRSB2DmGW5lOf5OZPqnoBqv7JpBRmDy61BM3Jp13BMOCSZsjFObvwMH8ogjbFeZeNeeeObeGU4EUQ6KcNoHzE004DrLEZ3d');
    stripe.redirectToCheckout({
        sessionId: sessionId
    });
}