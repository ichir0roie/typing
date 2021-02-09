

qwrtext = "qwertyuiopasdfghjklzxcvbnm"
colemak = "qwfpgjluyharstdneiozxcvbkm"

if __name__ == '__main__':
    for c in range(len(qwrtext)):
        if qwrtext[c] != colemak[c]:
            print(qwrtext[c] + "::"+colemak[c])
