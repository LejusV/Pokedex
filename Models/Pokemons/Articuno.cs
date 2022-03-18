using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Articuno Species to store common natural stats of all Articunos
	#region SpeciesArticuno
	public class SpeciesArticuno : PokemonSpecies
	{
#nullable enable
		private static SpeciesArticuno? _instance = null;
#nullable restore
        public static SpeciesArticuno Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesArticuno();
                }
                return _instance;
            }
        }

		#region SpeciesArticuno Constructor
		public SpeciesArticuno() : base(
			144,
			"Articuno",
			1.7,
			55.4,
			90, // HPs
			85, 100, // Attack & Defense
			95, 125, // Special Attack & Defense
			85		
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
				"Gust",
				"Whirlwind",
				"Fly",
				"Take-Down",
				"Double-Edge",
				"Roar",
				"Mist",
				"Water-Gun",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Hyper-Beam",
				"Peck",
				"Toxic",
				"Agility",
				"Rage",
				"Mimic",
				"Double-Team",
				"Reflect",
				"Bide",
				"Swift",
				"Sky-Attack",
				"Rest",
				"Substitute",
				"Mind-Reader",
				"Snore",
				"Curse",
				"Powder-Snow",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
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
				"Hail",
				"Facade",
				"Secret-Power",
				"Air-Cutter",
				"Signal-Beam",
				"Sheer-Cold",
				"Aerial-Ace",
				"Water-Pulse",
				"Roost",
				"Natural-Gift",
				"Pluck",
				"Tailwind",
				"U-Turn",
				"Giga-Impact",
				"Avalanche",
				"Ice-Shard",
				"Defog",
				"Ominous-Wind",
				"Round",
				"Sky-Drop",
				"Frost-Breath",
				"Hurricane",
				"Freeze-Dry",
				"Confide",
				"Aurora-Veil"
			};
		}
		#endregion
	}
	#endregion

	//Articuno PokemonInstance Class
	#region Articuno
	public class ArticunoInstance : PokemonInstance
	{
		#region Articuno Constructors
		/// <summary>
		/// Articuno Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ArticunoInstance(string nickname, int level)
		: base(
				SpeciesArticuno.Instance, // Pokemon Species
				nickname, level,
				Ice.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Articuno Builder only waiting for a Level
		/// </summary>
		public ArticunoInstance(int level)
		: base(
				SpeciesArticuno.Instance, // PokemonInstance Species
				"Articuno", level,
				Ice.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Articuno Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public ArticunoInstance() : base(
			SpeciesArticuno.Instance, // PokemonInstance Species
			Ice.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}