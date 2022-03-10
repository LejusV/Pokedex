using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Braixen Species to store common natural stats of all Braixens
	#region SpeciesBraixen
	public class SpeciesBraixen : PokemonSpecies
	{
#nullable enable
		private static SpeciesBraixen? _instance = null;
#nullable restore
        public static SpeciesBraixen Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesBraixen();
                }
                return _instance;
            }
        }

		#region SpeciesBraixen Constructor
		public SpeciesBraixen() : base(
			"Braixen",
			1.0,
			14.5,
			59, // HPs
			59, 58, // Attack & Defense
			90, 70, // Special Attack & Defense
			73		
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
				"Cut",
				"Tail-Whip",
				"Ember",
				"Flamethrower",
				"Psybeam",
				"Low-Kick",
				"Solar-Beam",
				"Fire-Spin",
				"Toxic",
				"Psychic",
				"Double-Team",
				"Light-Screen",
				"Fire-Blast",
				"Dream-Eater",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Heat-Wave",
				"Will-O-Wisp",
				"Facade",
				"Trick",
				"Magic-Coat",
				"Recycle",
				"Skill-Swap",
				"Snatch",
				"Secret-Power",
				"Overheat",
				"Howl",
				"Covet",
				"Shock-Wave",
				"Embargo",
				"Lucky-Chant",
				"Zen-Headbutt",
				"Grass-Knot",
				"Wonder-Room",
				"Psyshock",
				"Magic-Room",
				"Flame-Charge",
				"Foul-Play",
				"Round",
				"Echoed-Voice",
				"Incinerate",
				"Fire-Pledge",
				"Work-Up",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Braixen PokemonInstance Class
	#region Braixen
	public class BraixenInstance : PokemonInstance
	{
		#region Braixen Constructors
		/// <summary>
		/// Braixen Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public BraixenInstance(string nickname, int level)
		: base(
				654,
				SpeciesBraixen.Instance, // Pokemon Species
				nickname, level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Braixen Builder only waiting for a Level
		/// </summary>
		public BraixenInstance(int level)
		: base(
				654,
				SpeciesBraixen.Instance, // PokemonInstance Species
				"Braixen", level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Braixen Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Braixen() : base(
			654,
			SpeciesBraixen.Instance, // PokemonInstance Species
			Fire.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}