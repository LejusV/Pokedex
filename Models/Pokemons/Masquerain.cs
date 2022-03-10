using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Masquerain Species to store common natural stats of all Masquerains
	#region SpeciesMasquerain
	public class SpeciesMasquerain : PokemonSpecies
	{
#nullable enable
		private static SpeciesMasquerain? _instance = null;
#nullable restore
        public static SpeciesMasquerain Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesMasquerain();
                }
                return _instance;
            }
        }

		#region SpeciesMasquerain Constructor
		public SpeciesMasquerain() : base(
			"Masquerain",
			0.8,
			3.6,
			70, // HPs
			60, 62, // Attack & Defense
			100, 82, // Special Attack & Defense
			80		
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
				"Gust",
				"Whirlwind",
				"Double-Edge",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Solar-Beam",
				"Stun-Spore",
				"String-Shot",
				"Toxic",
				"Quick-Attack",
				"Mimic",
				"Double-Team",
				"Swift",
				"Bubble",
				"Flash",
				"Rest",
				"Substitute",
				"Thief",
				"Nightmare",
				"Snore",
				"Protect",
				"Scary-Face",
				"Mud-Slap",
				"Icy-Wind",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Sweet-Scent",
				"Hidden-Power",
				"Twister",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Facade",
				"Secret-Power",
				"Air-Cutter",
				"Silver-Wind",
				"Signal-Beam",
				"Aerial-Ace",
				"Water-Sport",
				"Water-Pulse",
				"Roost",
				"Natural-Gift",
				"Tailwind",
				"U-Turn",
				"Air-Slash",
				"Bug-Buzz",
				"Energy-Ball",
				"Giga-Impact",
				"Defog",
				"Captivate",
				"Bug-Bite",
				"Ominous-Wind",
				"Quiver-Dance",
				"Round",
				"Scald",
				"Struggle-Bug",
				"Confide",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion

	//Masquerain PokemonInstance Class
	#region Masquerain
	public class MasquerainInstance : PokemonInstance
	{
		#region Masquerain Constructors
		/// <summary>
		/// Masquerain Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public MasquerainInstance(string nickname, int level)
		: base(
				284,
				SpeciesMasquerain.Instance, // Pokemon Species
				nickname, level,
				Bug.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Masquerain Builder only waiting for a Level
		/// </summary>
		public MasquerainInstance(int level)
		: base(
				284,
				SpeciesMasquerain.Instance, // PokemonInstance Species
				"Masquerain", level,
				Bug.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Masquerain Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Masquerain() : base(
			284,
			SpeciesMasquerain.Instance, // PokemonInstance Species
			Bug.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}