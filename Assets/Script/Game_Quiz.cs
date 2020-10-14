using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game_Quiz : MonoBehaviour
{
    public Text Title;
    public Text Content;
    string[] question;
    string[] answer;
    public static int index;
    public static int max_index;
    private string title;
    //public int test;

    

    // Start is called before the first frame update
    void Start()
    {
       
        Game_Quiz.index = 0;
        Game_Quiz.max_index = 2;
        //Main_System.now_quizing = "Solar";
    }

    void Update()
    {
        restart();
        Content.text = question[index];
        Title.text = title;
        Main_System.quiz_answer = answer[index];
    }

    void restart()
    {
        
        switch (Main_System.now_quizing)
        {
            case "Solar":
                title = "Solar Sail";
                question = new string[]
                {
                    "Q1. Which of the following is the huge panel of the solar sail mainly composed of?  \n(A) Solar panel         \n(B) Thin film lens  \n (C) Sail                \n (D) LCD",
                    "Q2. The following options are the shortcomings of the solar sail, which is false?  \n(A) The initial speed is slow  \n (B) need Light to travel \n (C) require a lot of fuel  \n (D) be able to withstand high temperatures.",
                    "Q3. Which of the following is the first solar sail-powered detector in the world?  \n (A)IKAROS  \n (B)IRKOAS  \n (C)IROKAS  \n (D)IKORAS",};
                answer = new string[] {"B", "C", "A"};
                break;

            case "MassDriver":
                title = "Mass Driver";
                question = new string[]
                {
                    "Q1, which is not the principle for rail gun to work ? \n (A) current magnetic effect \n(B)	Laurence Force \n(C) Newton's second law of motion \n (D) Lenz law",
                    "Q2, which of the following narratives is correct? \n (A) coil gun’s energy-used efficiency is high. \n (B) magnetic rail gun uses chemical energy as momentum.\n (C) maglev train uses electromagnetic force to work. \n (D) The upper limit of G force that humans can withstand is about 19G.",
                    "Q3, about the mass driver, which of the following is correct? \n (A) the launch orbit is short. \n (B) the launch orbit is short. \n (C) energy demand is small.t \n (D) NASA once sent a spacecraft into space with a mass driver." ,""};
                answer = new string[] { "D", "C", "B" };
                break;

            case "NEMP":
                title = "NEMP";
                question = new string[]
                {
                    "Q1. Which principle does the main power of nuclear pulse propulsion come from?  \n(A) Nuclear fusion \n(B) Mitosis  \n(C) Light \n(D) Gravity traction",
                    "Q2. What are the main raw materials for nuclear pulse propulsion? \n(A) Uranium-235, Plutonium-239 \n(B) Deuterium, Tritium \n(C) Lithium-6, Boron-11 \n(D) Hydrogen, Oxygen",
                    "Q3. Which of the following is not the main disadvantage of NEMP? \n(A) Heavy  \n(B) Power source is hazard \n(C) The safety of passengers  \n(D) Low feasibility"};
                answer = new string[] { "B", "A", "D" };
                break;

            case "Bussard":
                title = "Bussard Ramjet";
                question = new string[]
                {
                    "Q1. What principle does the main power of Bussard ramjet propulsion come from?  \n(A) Nuclear fusion \n(B) Mitosis  \n(C) Light \n(D) Gravity traction",
                    "Q2. Which of the following groups are the main raw materials for Bussard ramjet propulsion? \nA. uranium-235, plutonium-239  B. deuterium, thorium  \nC. lithium-6, boron-11  D. hydrogen, hydrogen ions. \n (A) A, B      (B) A, C       (C) B, C      (D) C, D",
                    "Q3. Which of the following is not the main dilemma of Bussard ramjet? \n (A) The initial speed needed is too high  \n(B) power source is hazard \n(C) nuclear fusion is not yet manageable \n(D) all of above"};
                answer = new string[] { "A", "D", "B" };
                break;

            case "MPD":
                title = "MPD";
                question = new string[]
                {
                    "Q1. Which is the fuel of most MPD? \n(A) Hydrogen \n(B) Helium \n(C) Nitrogen \n(D) Xenon",
                    "Q2. What is the reason for the previous question? \n (A) Easy to obtain \n(B) Light weight \n(C) Is not prone to reaction. \n(D) Flammable",
                    "Q3. What are the characteristics of MPD? \n (A) Large thrust \n(B) has great specific impulse. \n(C) Fuel consumption is high. \n(D) can operate in non-vacuum situations."
                };
                answer = new string[] { "A", "D", "B" };
                break;

            case "Warp":
                title = "Warp Drive";
                question = new string[]
                {
                   "Q1. Which of the following is the key setting for the warp drive? \n(A) The space expended behind. \n(B) The space compressed in front. \n(C) The space-distorting bubble that surrounds the ship in the middle. \n(D) All of the above" ,
                   "Q2. What did the scientists confirm in 2016 and prove to be possible to travel with space distortion? \n(A) Gravitational waves. \n(B) Black hole \n(C) r-ray \n(D) White hole",
                   "Q3. Do you believe there will be a warp drive in the future? \n(A) Yes \n(B) No"
                };
                answer = new string[] { "D", "A", "A" };
                break;
        }
    }

}