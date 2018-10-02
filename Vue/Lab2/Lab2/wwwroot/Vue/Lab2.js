
var counter = new Vue({
    el: '#counter',
    data: {
        counter: 0
    },
    computed: {
        sometext: function () {
            if (this.counter > 10 && this.counter <20)
                return "Du har nu tryckt 10 gånger på knappen"
            if (this.counter >=20)
                return "Du har nu tryckt över 20 jävla gånger"
            
        }
    }

})