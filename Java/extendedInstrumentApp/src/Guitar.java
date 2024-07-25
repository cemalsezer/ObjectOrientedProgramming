public class Guitar implements Instrument, ElectronicInsturment {

    @Override
    public void play() {
        System.out.println("Playing the guitar");
    }
    
    public void setChord(){
        System.out.println("The guitar has been tuned.");
    }

    @Override
    public void tune() {
        System.out.println("Guitar is being tuned.");

    }
}
