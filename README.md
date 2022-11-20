# Activity 7
## Jesse Dalton
### CST 150

Video Presentation of activity:
[Loom video](https://www.loom.com/share/f9ff5d659e6a4e948d639fb608630de7)

Screenshots available in 
[/gcu/img/](https://github.com/jmdalton0/cst150-act7/tree/main/gcu/img)

### Approximate Pi
Simple Windows Form Application to approximate pi using the following formula:

4 - 4/3 + 4/5 - 4/7 + 4/9 - 4/11 ...

### What I Learned
I had some issues with casting between ints and doubles.
At first my results were pretty much always 5.
I realized this was because I was performing integer division, which just results in truncating the decimal part of the number.
Once I changed the right hard-coded values to doubles, the program correctly used decimal division and calculated the numbers with a decimal part.
