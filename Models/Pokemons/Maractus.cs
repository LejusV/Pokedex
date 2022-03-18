using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Maractus Species to store common natural stats of all Maractuss
	#region SpeciesMaractus
	public class SpeciesMaractus : PokemonSpecies
	{
#nullable enable
		private static SpeciesMaractus? _instance = null;
#nullable restore
        public static SpeciesMaractus Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesMaractus();
                }
                return _instance;
            }
        }

		#region SpeciesMaractus Constructor
		public SpeciesMaractus() : base(
			556,
			"Maractus",
			1.0,
			28.0,
			75, // HPs
			86, 67, // Attack & Defense
			106, 67, // Special Attack & Defense
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
				"Pin-Missile",
				"Peck",
				"Absorb",
				"Mega-Drain",
				"Leech-Seed",
				"Growth",
				"Solar-Beam",
				"Petal-Dance",
				"Toxic",
				"Double-Team",
				"Rest",
				"Substitute",
				"Snore",
				"Cotton-Spore",
				"Protect",
				"Spikes",
				"Giga-Drain",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Sweet-Scent",
				"Synthesis",
				"Hidden-Power",
				"Sunny-Day",
				"Uproar",
				"Facade",
				"Nature-Power",
				"Helping-Hand",
				"Ingrain",
				"Knock-Off",
				"Endeavor",
				"Secret-Power",
				"Needle-Arm",
				"Hyper-Voice",
				"Grass-Whistle",
				"Bullet-Seed",
				"Aerial-Ace",
				"Bounce",
				"Acupressure",
				"Worry-Seed",
				"Sucker-Punch",
				"Poison-Jab",
				"Seed-Bomb",
				"Drain-Punch",
				"Energy-Ball",
				"Grass-Knot",
				"Wood-Hammer",
				"After-You",
				"Round",
				"Cotton-Guard",
				"Petal-Blizzard",
				"Grassy-Terrain",
				"Confide",
				"Spiky-Shield"
			};
		}
		#endregion
	}
	#endregion

	//Maractus PokemonInstance Class
	#region Maractus
	public class MaractusInstance : PokemonInstance
	{
		#region Maractus Constructors
		/// <summary>
		/// Maractus Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public MaractusInstance(string nickname, int level)
		: base(
				SpeciesMaractus.Instance, // Pokemon Species
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Maractus Builder only waiting for a Level
		/// </summary>
		public MaractusInstance(int level)
		: base(
				SpeciesMaractus.Instance, // PokemonInstance Species
				"Maractus", level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Maractus Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public MaractusInstance() : base(
			SpeciesMaractus.Instance, // PokemonInstance Species
			Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}