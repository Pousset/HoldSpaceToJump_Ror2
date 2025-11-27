using BepInEx;
using RoR2;
using UnityEngine;

namespace HoldSpaceMod
{
    [BepInPlugin(PluginGUID, PluginName, PluginVersion)]
    public class HoldSpaceMod : BaseUnityPlugin
    {
        public const string PluginGUID = PluginAuthor + "." + PluginName;
        public const string PluginAuthor = "AuthorName";
        public const string PluginName = "HoldSpaceMod";
        public const string PluginVersion = "1.0.0";
        
        // Variables pour l'auto jump
        public bool jump = false;
        private bool spaceWasPressed = false;
        private float spaceHoldTime = 0f;
        private const float HOLD_THRESHOLD = 0.15f; // Temps pour différencier appui/maintien

        public void Awake()
        {
            Log.Init(Logger);
            
            // Hook pour l'auto jump
            On.RoR2.PlayerCharacterMasterController.Update += AutoJump;

            Log.Info(nameof(Awake) + " done.");
        }

        // Méthode Auto Jump améliorée avec détection appui court/maintien
        private void AutoJump(On.RoR2.PlayerCharacterMasterController.orig_Update orig, PlayerCharacterMasterController self)
        {
            orig.Invoke(self);

#pragma warning disable Publicizer001
            if (self.body == null)
            {
                return;
            }

            // Détection pour vérifier si la touche espace est maintenue
            if (Input.GetKey(KeyCode.Space))
            {
                if (!spaceWasPressed)
                {
                    spaceWasPressed = true;
                    spaceHoldTime = 0f;
                }
                else
                {
                    spaceHoldTime += Time.deltaTime;
                }
            }
            else
            {
                // Réinitialise quand on relâche
                spaceWasPressed = false;
                spaceHoldTime = 0f;
            }

            // Active l'auto-jump SEULEMENT si on maintient assez longtemps
            bool enableAutoJump = spaceHoldTime >= HOLD_THRESHOLD;

            // Logique Auto Jump (activée seulement si maintien prolongé)
            if (enableAutoJump)
            {
                if (jump && self.bodyInputs != null && 
                    self.bodyInputs.jump.down && self.bodyMotor != null && 
                    self.bodyMotor.isGrounded)
                {
                    self.bodyInputs.jump.down = false;
                    jump = false;
                }

                if (!jump && self.bodyMotor != null && !self.bodyMotor.isGrounded)
                {
                    jump = true;
                }
            }
            else
            {
                // Si appui court, réinitialise pour permettre le comportement normal
                jump = false;
            }
#pragma warning restore Publicizer001
        }
    }
}