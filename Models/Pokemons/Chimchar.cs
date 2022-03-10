using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Chimchar Species to store common natural stats of all Chimchars
	#region SpeciesChimchar
	public class SpeciesChimchar : PokemonSpecies
	{
#nullable enable
		private static SpeciesChimchar? _instance = null;
#nullable restore
        public static SpeciesChimchar Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesChimchar();
                }
                return _instance;
            }
        }

		#region SpeciesChimchar Constructor
		public SpeciesChimchar() : base(
			"Chimchar",
			0.5,
			6.2,
			44, // HPs
			58, 44, // Attack & Defense
			58, 44, // Special Attack & Defense
			61		
		)
		{
			InitMovesList();
		}
		#endregion

		#region Methods
		private void InitMovesList()
		{
			_moveList = new List<string>()
			{
				"Fire-Punch",
				"Thunder-Punch",
				"Scratch",
				"Swords-Dance",
				"Cut",
				"Double-Kick",
				"Headbutt",
				"Leer",
				"Ember",
				"Flamethrower",
				"Submission",
				"Low-Kick",
				"Counter",
				"Strength",
				"Fire-Spin",
				"Dig",
				"Toxic",
				"Double-Team",
				"Focus-Energy",
				"Fire-Blast",
				"Swift",
				"Fury-Swipes",
				"Rest",
				"Substitute",
				"Flame-Wheel",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Encore",
				"Iron-Tail",
				"Hidden-Power",
				"Sunny-Day",
				"Rock-Smash",
				"Fake-Out",
				"Uproar",
				"Heat-Wave",
				"Torment",
				"Will-O-Wisp",
				"Facade",
				"Focus-Punch",
				"Taunt",
				"Helping-Hand",
				"Role-Play",
				"Assist",
				"Brick-Break",
				"Endeavor",
				"Secret-Power",
				"Blaze-Kick",
				"Slack-Off",
				"Overheat",
				"Aerial-Ace",
				"Bulk-Up",
				"Covet",
				"Natural-Gift",
				"U-Turn",
				"Fling",
				"Vacuum-Wave",
				"Nasty-Plot",
				"Shadow-Claw",
				"Rock-Climb",
				"Gunk-Shot",
				"Captivate",
				"Stealth-Rock",
				"Grass-Knot",
				"Hone-Claws",
				"Flame-Charge",
				"Low-Sweep",
				"Round",
				"Quick-Guard",
				"Incinerate",
				"Acrobatics",
				"Fire-Pledge",
				"Work-Up",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Chimchar PokemonInstance Class
	#region Chimchar
	public class ChimcharInstance : PokemonInstance
	{
		#region Chimchar Constructors
		/// <summary>
		/// Chimchar Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ChimcharInstance(string nickname, int level)
		: base(
				390,
				SpeciesChimchar.Instance, // Pokemon Species
				nickname, level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Chimchar Builder only waiting for a Level
		/// </summary>
		public ChimcharInstance(int level)
		: base(
				390,
				SpeciesChimchar.Instance, // PokemonInstance Species
				"Chimchar", level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Chimchar Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Chimchar() : base(
			390,
			SpeciesChimchar.Instance, // PokemonInstance Species
			Fire.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}