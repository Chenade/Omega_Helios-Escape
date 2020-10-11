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
                    "Which of the following are the main components of the huge panel of the solar sail? \n(A) Solar panel         (B) Thin film lens  \n (C) Sail                 (D) LCD device",
                    "What is the shortcoming of solar sail? \n(A) The initial speed is slow  \n (B) It needs light to travel \n (C) It consumes a lot of fuel \n (D) It needs to be able to withstand high temperatures",
                    "Which of the following is the world's first solar sail-powered probe? \n (A)IKAROS  \n (B)IRKOAS  \n (C)IROKAS  \n (D)IKORAS",};
                answer = new string[] {"B", "C", "A"};
                break;

            case "MassDriver":
                title = "Mass Driver";
                question = new string[]
                {
                    "Q1, the principle of the railgun (Railgun), which of the following is wrong? \n (A) Current magnetic effect \n(B) Lorentz force \n(C) Newton's second law of motion \n (D) cold order law",
                    "Q2, which of the following statements is correct? \n (A) Coilgun has high energy use efficiency \n (B) Railgun is a kinetic energy weapon that directly uses chemical energy\n (C) Maglev train is a kind of electromagnetic force Vehicle \n (D) The upper limit of the G force that humans can bear is about 19G",
                    "Q3. Regarding the mass projector, which of the following is correct? \n (A) Short launch trajectory \n (B) Wide application range \n (C) Low energy requirement \n (D) NASA used the mass projector to send spacecraft into space" ,""};
                answer = new string[] { "D", "C", "B" };
                break;

            case "NEMP":
                title = "NEMP";
                question = new string[]
                {
                    "Q1. What is the principle of nuclear pulse propulsion? \n (A) Nuclear fusion (B) Nuclear fission (C) Light energy (D) Gravity pull",
                    "Q2. What are the main raw materials for nuclear pulse propulsion? \n (A) Uranium-235, Plutonium-239 (B) Deuterium, Tritium (C) Lithium-6, Boron-11 (D) Hydrogen, Oxygen",
                    "Q3. Which of the following is not the main disadvantage of nuclear pulse propulsion? \n (A) Overweight (B) Dangerous source of power (C) Passenger safety issues (D) Low feasibility"};
                answer = new string[] { "B", "A", "D" };
                break;

            case "Bussard":
                title = "Bussard Ramjet";
                question = new string[]
                {
                    "Q1. What is the principle of interstellar stamping propulsion? \n (A) Nuclear Fusion (B) Nuclear Fission (C) Light Energy (D) Gravity Pull",
                    "Q2. Which of the following groups are the main raw materials for interstellar stamping? \n (A) Uranium-235, Plutonium-239 (B) Deuterium, Tritium (C) Lithium-6, Boron-11 (D) Hydrogen, Hydrogen ions \n (A) A, B (B) A, C (C) B, C (D) C, D",
                    "Q3. Which of the following is not the main dilemma of interstellar stamping? \n (A) Threshold of initial velocity is too high (B) Power source is dangerous (C) Nuclear fusion is not yet controllable"};
                answer = new string[] { "A", "D", "B" };
                break;

            case "MPD":
                title = "MDP";
                question = new string[]
                {
                    "Q: What is the current fuel for most ion thrusters? \n (A) Hydrogen (B) Helium (C) Nitrogen (D) Xenon",
                    "Q: Submit the question, why? \n (A) Easy to obtain (B) Light weight (C) Not easy to react (D) Flammable",
                    "Q: What are the characteristics of ion thrusters? \n (A) Large thrust (B) Large specific impulse (C) High fuel consumption (D) Can operate in non-vacuum conditions"
                };
                answer = new string[] { "A", "D", "B" };
                break;

            case "Warp":
                title = "Warp Drive";
                question = new string[]
                {
                   "Q: Which of the following is the key setting of a warp engine? \n (A) The stretched space at the rear (B) The compressed space at the front (C) The curved space surrounding the spacecraft is cavitation (D) All of the above" ,
                    "Q: In 2016, what phenomenon did the scientific community prove to increase the possibility of warp navigation? \n (A) Gravity wave (B) Black hole (C) r-ray (D) White hole",
                    "Q: Do you believe that there will be a speed engine in the future? \n (A) Yes (B) No"
                };
                answer = new string[] { "D", "A", "A" };
                break;
        }
    }

}