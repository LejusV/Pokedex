using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Surskit Species to store common natural stats of all Surskits
	#region SpeciesSurskit
	public class SpeciesSurskit : PokemonSpecies
	{
#nullable enable
		private static SpeciesSurskit? _instance = null;
#nullable restore
        public static SpeciesSurskit Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesSurskit();
                }
                return _instance;
            }
        }

		#region SpeciesSurskit Constructor
		public SpeciesSurskit() : base(
			"Surskit",
			0.5,
			1.7,
			40, // HPs
			30, 32, // Attack & Defense
			50, 52, // Special Attack & Defense
			65		
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
				"Double-Edge",
				"Mist",
				"Hydro-Pump",
				"Ice-Beam",
				"Blizzard",
				"Psybeam",
				"Bubble-Beam",
				"Solar-Beam",
				"String-Shot",
				"Toxic",
				"Agility",
				"Quick-Attack",
				"Mimic",
				"Double-Team",
				"Haze",
				"Swift",
				"Bubble",
				"Flash",
				"Rest",
				"Substitute",
				"Thief",
				"Mind-Reader",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Foresight",
				"Icy-Wind",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Baton-Pass",
				"Sweet-Scent",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Facade",
				"Secret-Power",
				"Signal-Beam",
				"Mud-Shot",
				"Water-Sport",
				"Water-Pulse",
				"Natural-Gift",
				"Captivate",
				"Bug-Bite",
				"Aqua-Jet",
				"Power-Split",
				"Round",
				"Scald",
				"Struggle-Bug",
				"Sticky-Web",
				"Fell-Stinger",
				"Confide",
				"Infestation",
				"Lunge"
			};
		}
		#endregion
	}
	#endregion

	//Surskit PokemonInstance Class
	#region Surskit
	public class SurskitInstance : PokemonInstance
	{
		#region Surskit Constructors
		/// <summary>
		/// Surskit Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public SurskitInstance(string nickname, int level)
		: base(
				283,
				SpeciesSurskit.Instance, // Pokemon Species
				nickname, level,
				Bug.Instance, Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Surskit Builder only waiting for a Level
		/// </summary>
		public SurskitInstance(int level)
		: base(
				283,
				SpeciesSurskit.Instance, // PokemonInstance Species
				"Surskit", level,
				Bug.Instance, Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Surskit Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Surskit() : base(
			283,
			SpeciesSurskit.Instance, // PokemonInstance Species
			Bug.Instance, Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}