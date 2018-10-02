
var listor = new Vue({
    el: '#listor',
    data: {

        list: ["Royal", "Etheline", "Harry",
            "Chas", "Richie", "Margot", "Ari", "Uzi"],
        checked: true,
        sometext: ""
       
    },
    computed: {
        listWithR: function () {
            //const RList = list.filter((name) => name.RList("R"));
            //return RList;
            //const countries = ['Norway', 'Sweden', 'Denmark', 'New Zealand'];

            return this.list.filter((name) => name.startsWith("R"));
        },
        teckenList: function () {
            if (this.sometext !== "") {

                if (!this.checked) {
                    return this.list.filter((name) => name.toUpperCase().startsWith(this.sometext.toUpperCase()))

                }
                else
                    return this.list.filter((name) => name.startsWith(this.sometext))
            }
        }
    },
    methods: {
        addName() {
            this.list.push(this.newName);
        }
    }



});