using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Zapdos Species to store common natural stats of all Zapdoss
	#region SpeciesZapdos
	public class SpeciesZapdos : PokemonSpecies
	{
#nullable enable
		private static SpeciesZapdos? _instance = null;
#nullable restore
        public static SpeciesZapdos Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesZapdos();
                }
                return _instance;
            }
        }

		#region SpeciesZapdos Constructor
		public SpeciesZapdos() : base(
			145,
			"Zapdos",
			1.6,
			52.6,
			90, // HPs
			90, 85, // Attack & Defense
			125, 90, // Special Attack & Defense
			100		
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
				"Razor-Wind",
				"Whirlwind",
				"Fly",
				"Take-Down",
				"Double-Edge",
				"Roar",
				"Hyper-Beam",
				"Peck",
				"Drill-Peck",
				"Thunder-Shock",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Agility",
				"Rage",
				"Mimic",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Bide",
				"Swift",
				"Sky-Attack",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Zap-Cannon",
				"Detect",
				"Sandstorm",
				"Endure",
				"Swagger",
				"Steel-Wing",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Twister",
				"Rain-Dance",
				"Sunny-Day",
				"Ancient-Power",
				"Rock-Smash",
				"Heat-Wave",
				"Facade",
				"Charge",
				"Secret-Power",
				"Air-Cutter",
				"Signal-Beam",
				"Aerial-Ace",
				"Shock-Wave",
				"Roost",
				"Natural-Gift",
				"Pluck",
				"Tailwind",
				"U-Turn",
				"Giga-Impact",
				"Defog",
				"Discharge",
				"Charge-Beam",
				"Ominous-Wind",
				"Round",
				"Sky-Drop",
				"Volt-Switch",
				"Wild-Charge",
				"Confide",
				"Magnetic-Flux"
			};
		}
		#endregion
	}
	#endregion

	//Zapdos PokemonInstance Class
	#region Zapdos
	public class ZapdosInstance : PokemonInstance
	{
		#region Zapdos Constructors
		/// <summary>
		/// Zapdos Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ZapdosInstance(string nickname, int level)
		: base(
				SpeciesZapdos.Instance, // Pokemon Species
				nickname, level,
				Electric.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Zapdos Builder only waiting for a Level
		/// </summary>
		public ZapdosInstance(int level)
		: base(
				SpeciesZapdos.Instance, // PokemonInstance Species
				"Zapdos", level,
				Electric.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Zapdos Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public ZapdosInstance() : base(
			SpeciesZapdos.Instance, // PokemonInstance Species
			Electric.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}