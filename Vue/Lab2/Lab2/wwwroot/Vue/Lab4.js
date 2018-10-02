

var varukorg = new Vue({
    el: '#varukorg',
    data: {
        products: [],
        
    },
    methods: {
        addPlus: function (x) {
            x.quantity++;
        },
        addMinus: function (x) {
            x.quantity--;
            if (x.quantity < 0)
                x.quantity = 0
        }
    },
    created: async function callingApi() {
        let response = await fetch("/products", { method: "GET" });
        this.products = await response.json();
        
    },
        computed: {
            theSum: function () {

                let sum = 0;
                for (let x of this.products) {
                    sum += x.quantity;
                }
                return sum;
            }

        }
})
