using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class dialogueManager : MonoBehaviour
{
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI dialogueText;
    public Animator Animator;
    public GameObject dialoguebox;
    public GameObject gate;
    public bool ted = false;


    private Queue<string> sentences;
    
    void Start()
    {
        sentences = new Queue<string>();
    }

    void Update(){
        if(ted == true){
            StartCoroutine(Timer());
        }
     }
    IEnumerator Timer(){
        yield return new WaitForSeconds(1);
        dialoguebox.SetActive(false);
        gate.SetActive(false);
        ted = false;
    }

    public void StartDialogue (Dialogue dialogue){
        Animator.SetBool("IsOpen", true);

        nameText.text = dialogue.name;

        sentences.Clear();

        foreach (string sentence in dialogue.sentences){
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }
    public void DisplayNextSentence(){
        if (sentences.Count == 0){
            EndDialogue();
            ted = true;
            return;
        }

        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    IEnumerator TypeSentence (string sentence){
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray()){
            dialogueText.text += letter;
            yield return null;
        }
    }

    public void EndDialogue(){
        Debug.Log ("End of conversation");
        Animator.SetBool("IsOpen", false);
    }
}
