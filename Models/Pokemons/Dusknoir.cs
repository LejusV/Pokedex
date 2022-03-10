using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Dusknoir Species to store common natural stats of all Dusknoirs
	#region SpeciesDusknoir
	public class SpeciesDusknoir : PokemonSpecies
	{
#nullable enable
		private static SpeciesDusknoir? _instance = null;
#nullable restore
        public static SpeciesDusknoir Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesDusknoir();
                }
                return _instance;
            }
        }

		#region SpeciesDusknoir Constructor
		public SpeciesDusknoir() : base(
			"Dusknoir",
			2.2,
			106.6,
			45, // HPs
			100, 135, // Attack & Defense
			65, 135, // Special Attack & Defense
			45		
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
				"Ice-Punch",
				"Thunder-Punch",
				"Bind",
				"Headbutt",
				"Leer",
				"Disable",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Strength",
				"Earthquake",
				"Toxic",
				"Psychic",
				"Night-Shade",
				"Double-Team",
				"Confuse-Ray",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Spite",
				"Protect",
				"Mud-Slap",
				"Foresight",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Mean-Look",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pain-Split",
				"Pursuit",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Future-Sight",
				"Rock-Smash",
				"Torment",
				"Will-O-Wisp",
				"Facade",
				"Focus-Punch",
				"Taunt",
				"Trick",
				"Brick-Break",
				"Skill-Swap",
				"Snatch",
				"Secret-Power",
				"Astonish",
				"Rock-Tomb",
				"Shadow-Punch",
				"Calm-Mind",
				"Gravity",
				"Natural-Gift",
				"Payback",
				"Embargo",
				"Fling",
				"Sucker-Punch",
				"Dark-Pulse",
				"Focus-Blast",
				"Giga-Impact",
				"Shadow-Sneak",
				"Trick-Room",
				"Captivate",
				"Charge-Beam",
				"Ominous-Wind",
				"Wonder-Room",
				"Telekinesis",
				"Round",
				"Hex",
				"Bulldoze",
				"Confide",
				"Infestation",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Dusknoir PokemonInstance Class
	#region Dusknoir
	public class DusknoirInstance : PokemonInstance
	{
		#region Dusknoir Constructors
		/// <summary>
		/// Dusknoir Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public DusknoirInstance(string nickname, int level)
		: base(
				477,
				SpeciesDusknoir.Instance, // Pokemon Species
				nickname, level,
				Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dusknoir Builder only waiting for a Level
		/// </summary>
		public DusknoirInstance(int level)
		: base(
				477,
				SpeciesDusknoir.Instance, // PokemonInstance Species
				"Dusknoir", level,
				Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dusknoir Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Dusknoir() : base(
			477,
			SpeciesDusknoir.Instance, // PokemonInstance Species
			Ghost.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}