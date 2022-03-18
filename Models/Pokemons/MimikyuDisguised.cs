using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Mimikyu-Disguised Species to store common natural stats of all Mimikyu-Disguiseds
	#region SpeciesMimikyu-Disguised
	public class SpeciesMimikyuDisguised : PokemonSpecies
	{
#nullable enable
		private static SpeciesMimikyuDisguised? _instance = null;
#nullable restore
        public static SpeciesMimikyuDisguised Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesMimikyuDisguised();
                }
                return _instance;
            }
        }

		#region SpeciesMimikyu-Disguised Constructor
		public SpeciesMimikyuDisguised() : base(
			778,
			"Mimikyu-Disguised",
			0.2,
			0.7,
			55, // HPs
			90, 80, // Attack & Defense
			50, 105, // Special Attack & Defense
			96		
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
				"Scratch",
				"Swords-Dance",
				"Hyper-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Psychic",
				"Mimic",
				"Double-Team",
				"Light-Screen",
				"Dream-Eater",
				"Leech-Life",
				"Splash",
				"Rest",
				"Slash",
				"Substitute",
				"Thief",
				"Nightmare",
				"Curse",
				"Protect",
				"Feint-Attack",
				"Destiny-Bond",
				"Charm",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Pain-Split",
				"Hidden-Power",
				"Psych-Up",
				"Shadow-Ball",
				"Will-O-Wisp",
				"Facade",
				"Taunt",
				"Grudge",
				"Astonish",
				"Bulk-Up",
				"Payback",
				"Embargo",
				"Fling",
				"Copycat",
				"Dark-Pulse",
				"X-Scissor",
				"Shadow-Claw",
				"Shadow-Sneak",
				"Trick-Room",
				"Charge-Beam",
				"Wood-Hammer",
				"Hone-Claws",
				"Round",
				"Work-Up",
				"Play-Rough",
				"Confide",
				"Dazzling-Gleam",
				"Baby-Doll-Eyes",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion

	//Mimikyu-Disguised PokemonInstance Class
	#region Mimikyu-Disguised
	public class MimikyuDisguisedInstance : PokemonInstance
	{
		#region Mimikyu-Disguised Constructors
		/// <summary>
		/// Mimikyu-Disguised Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public MimikyuDisguisedInstance(string nickname, int level)
		: base(
				SpeciesMimikyuDisguised.Instance, // Pokemon Species
				nickname, level,
				Ghost.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mimikyu-Disguised Builder only waiting for a Level
		/// </summary>
		public MimikyuDisguisedInstance(int level)
		: base(
				SpeciesMimikyuDisguised.Instance, // PokemonInstance Species
				"Mimikyu-Disguised", level,
				Ghost.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mimikyu-Disguised Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public MimikyuDisguisedInstance() : base(
			SpeciesMimikyuDisguised.Instance, // PokemonInstance Species
			Ghost.Instance, Fairy.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}