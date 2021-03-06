/*
var homes = [
    {"h_id":"3", "city":"Dallas", "state":"TX","zip":"75201","price":"162500"},
    {"h_id":"4","city":"Bevery Hills", "state":"CA", "zip":"90210", "price":"319250"},
    {"h_id":"6", "city":"Dallas", "state":"TX", "zip":"75000", "price":"556699"},
    {"h_id":"5", "city":"New York", "state":"NY", "zip":"00010", "price":"962500"}
    ];

//homes.sort(fieldSorter(['city', 'price']));
homes.sort(fieldSorter(['city', 'zip', '-state', 'price'])); // alternative
*/
function fieldSorter(fields) {
    return function (a, b) {
        return fields
            .map(function (o) {
                var dir = 1;
                if (o[0] === '-') {
                   dir = -1;
                   o=o.substring(1);
                }
                if (a[o] > b[o]) return dir;
                if (a[o] < b[o]) return -(dir);
                return 0;
            })
            .reduce(function firstNonZeroValue (p,n) {
                return p ? p : n;
            }, 0);
    };
}

function getMinDiff(arr) {
	if(arr.length <= 1) {
		return 0;
	}
	var a = arr.sort(function(a, b){return a-b});
	var minDiff = a[1] - a[0];
	for ( i = 2 ; i != a.length ; i++) {
		if(a[i]-a[i-1] < minDiff)
		minDiff =a[i]-a[i-1];
	}
	return minDiff
}