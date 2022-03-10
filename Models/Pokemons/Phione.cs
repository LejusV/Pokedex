using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Phione Species to store common natural stats of all Phiones
	#region SpeciesPhione
	public class SpeciesPhione : PokemonSpecies
	{
#nullable enable
		private static SpeciesPhione? _instance = null;
#nullable restore
        public static SpeciesPhione Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesPhione();
                }
                return _instance;
            }
        }

		#region SpeciesPhione Constructor
		public SpeciesPhione() : base(
			"Phione",
			0.4,
			3.1,
			80, // HPs
			80, 80, // Attack & Defense
			80, 80, // Special Attack & Defense
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
				"Supersonic",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Toxic",
				"Double-Team",
				"Waterfall",
				"Swift",
				"Bubble",
				"Acid-Armor",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Endure",
				"Charm",
				"Swagger",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Frustration",
				"Safeguard",
				"Hidden-Power",
				"Rain-Dance",
				"Psych-Up",
				"Ancient-Power",
				"Whirlpool",
				"Uproar",
				"Hail",
				"Facade",
				"Helping-Hand",
				"Knock-Off",
				"Secret-Power",
				"Dive",
				"Signal-Beam",
				"Bounce",
				"Covet",
				"Water-Sport",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"U-Turn",
				"Fling",
				"Last-Resort",
				"Aqua-Ring",
				"Grass-Knot",
				"Round",
				"Scald",
				"Confide",
				"Dazzling-Gleam"
			};
		}
		#endregion
	}
	#endregion

	//Phione PokemonInstance Class
	#region Phione
	public class PhioneInstance : PokemonInstance
	{
		#region Phione Constructors
		/// <summary>
		/// Phione Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public PhioneInstance(string nickname, int level)
		: base(
				489,
				SpeciesPhione.Instance, // Pokemon Species
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Phione Builder only waiting for a Level
		/// </summary>
		public PhioneInstance(int level)
		: base(
				489,
				SpeciesPhione.Instance, // PokemonInstance Species
				"Phione", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Phione Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Phione() : base(
			489,
			SpeciesPhione.Instance, // PokemonInstance Species
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}