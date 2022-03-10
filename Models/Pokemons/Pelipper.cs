using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Pelipper Species to store common natural stats of all Pelippers
	#region SpeciesPelipper
	public class SpeciesPelipper : PokemonSpecies
	{
#nullable enable
		private static SpeciesPelipper? _instance = null;
#nullable restore
        public static SpeciesPelipper Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesPelipper();
                }
                return _instance;
            }
        }

		#region SpeciesPelipper Constructor
		public SpeciesPelipper() : base(
			"Pelipper",
			1.2,
			28.0,
			60, // HPs
			50, 100, // Attack & Defense
			95, 70, // Special Attack & Defense
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
				"Wing-Attack",
				"Fly",
				"Double-Edge",
				"Growl",
				"Supersonic",
				"Mist",
				"Water-Gun",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Swift",
				"Sky-Attack",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Steel-Wing",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Twister",
				"Rain-Dance",
				"Whirlpool",
				"Uproar",
				"Stockpile",
				"Spit-Up",
				"Swallow",
				"Hail",
				"Facade",
				"Knock-Off",
				"Secret-Power",
				"Air-Cutter",
				"Aerial-Ace",
				"Water-Sport",
				"Shock-Wave",
				"Water-Pulse",
				"Roost",
				"Brine",
				"Natural-Gift",
				"Pluck",
				"Tailwind",
				"U-Turn",
				"Payback",
				"Fling",
				"Seed-Bomb",
				"Giga-Impact",
				"Defog",
				"Gunk-Shot",
				"Captivate",
				"Ominous-Wind",
				"Soak",
				"Round",
				"Echoed-Voice",
				"Scald",
				"Sky-Drop",
				"Hurricane",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Pelipper PokemonInstance Class
	#region Pelipper
	public class PelipperInstance : PokemonInstance
	{
		#region Pelipper Constructors
		/// <summary>
		/// Pelipper Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public PelipperInstance(string nickname, int level)
		: base(
				279,
				SpeciesPelipper.Instance, // Pokemon Species
				nickname, level,
				Water.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pelipper Builder only waiting for a Level
		/// </summary>
		public PelipperInstance(int level)
		: base(
				279,
				SpeciesPelipper.Instance, // PokemonInstance Species
				"Pelipper", level,
				Water.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pelipper Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Pelipper() : base(
			279,
			SpeciesPelipper.Instance, // PokemonInstance Species
			Water.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}