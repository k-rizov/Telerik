function solve(args) {
    var nk = args[0].split(' ').map(Number),
        arr = args[1].split(' ').map(Number),
        n = +nk[0], k = +nk[1],
        result = 0, newArr = [],
        i, j, l;

    function mod(n, m) {
        return ((n % m) + m) % m;
    }

    function transform(num, leftNeighbour, rightNeighbour) {
        if (num === 0) {
            newArr[j] = Math.abs(leftNeighbour - rightNeighbour);
        }
        else if (num === 1) {
             newArr[j] = leftNeighbour + rightNeighbour;
        }
        else if (num % 2 === 0) {
            newArr[j] = Math.max(leftNeighbour, rightNeighbour);
        }
        else if (num % 2 !== 0) {
            newArr[j] = Math.min(leftNeighbour, rightNeighbour);
        }
    }

    if (k === 0) {
        for (i = 0; i < n; i += 1) {
            result += arr[i];
        }
    }
    else {
        for (i = 0; i < k; i += 1) {
            for (j = 0; j < n; j += 1) {
                transform(arr[j], arr[mod(j + 1, n)], arr[mod(j - 1, n)]);
            }

            if (i + 1 === k) {
                result = newArr.reduce((x, y) => x + y);
            }
            else {
                for (l = 0; l < n; l += 1) {
                    arr[l] = newArr[l];
                }
            }
        }
    }

    console.log(result);
}