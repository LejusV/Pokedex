using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Fennekin Species to store common natural stats of all Fennekins
	#region SpeciesFennekin
	public class SpeciesFennekin : PokemonSpecies
	{
#nullable enable
		private static SpeciesFennekin? _instance = null;
#nullable restore
        public static SpeciesFennekin Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesFennekin();
                }
                return _instance;
            }
        }

		#region SpeciesFennekin Constructor
		public SpeciesFennekin() : base(
			"Fennekin",
			0.4,
			9.4,
			40, // HPs
			45, 40, // Attack & Defense
			62, 60, // Special Attack & Defense
			60		
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
				"Cut",
				"Tail-Whip",
				"Ember",
				"Flamethrower",
				"Psybeam",
				"Solar-Beam",
				"Fire-Spin",
				"Toxic",
				"Psychic",
				"Hypnosis",
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
				"Wish",
				"Magic-Coat",
				"Secret-Power",
				"Overheat",
				"Howl",
				"Covet",
				"Embargo",
				"Lucky-Chant",
				"Grass-Knot",
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
				"Power-Up-Punch",
				"Psychic-Terrain"
			};
		}
		#endregion
	}
	#endregion

	//Fennekin PokemonInstance Class
	#region Fennekin
	public class FennekinInstance : PokemonInstance
	{
		#region Fennekin Constructors
		/// <summary>
		/// Fennekin Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public FennekinInstance(string nickname, int level)
		: base(
				653,
				SpeciesFennekin.Instance, // Pokemon Species
				nickname, level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Fennekin Builder only waiting for a Level
		/// </summary>
		public FennekinInstance(int level)
		: base(
				653,
				SpeciesFennekin.Instance, // PokemonInstance Species
				"Fennekin", level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Fennekin Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Fennekin() : base(
			653,
			SpeciesFennekin.Instance, // PokemonInstance Species
			Fire.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}