using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Lotad Species to store common natural stats of all Lotads
	#region SpeciesLotad
	public class SpeciesLotad : PokemonSpecies
	{
#nullable enable
		private static SpeciesLotad? _instance = null;
#nullable restore
        public static SpeciesLotad Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesLotad();
                }
                return _instance;
            }
        }

		#region SpeciesLotad Constructor
		public SpeciesLotad() : base(
			270,
			"Lotad",
			0.5,
			2.6,
			40, // HPs
			30, 30, // Attack & Defense
			40, 50, // Special Attack & Defense
			30		
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
				"Swords-Dance",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Growl",
				"Mist",
				"Water-Gun",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Counter",
				"Absorb",
				"Mega-Drain",
				"Leech-Seed",
				"Razor-Leaf",
				"Solar-Beam",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Bubble",
				"Flash",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Flail",
				"Protect",
				"Icy-Wind",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Sweet-Scent",
				"Synthesis",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Whirlpool",
				"Uproar",
				"Hail",
				"Facade",
				"Nature-Power",
				"Secret-Power",
				"Teeter-Dance",
				"Astonish",
				"Tickle",
				"Bullet-Seed",
				"Water-Pulse",
				"Natural-Gift",
				"Seed-Bomb",
				"Energy-Ball",
				"Zen-Headbutt",
				"Captivate",
				"Grass-Knot",
				"Round",
				"Echoed-Voice",
				"Scald",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Lotad PokemonInstance Class
	#region Lotad
	public class LotadInstance : PokemonInstance
	{
		#region Lotad Constructors
		/// <summary>
		/// Lotad Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public LotadInstance(string nickname, int level)
		: base(
				SpeciesLotad.Instance, // Pokemon Species
				nickname, level,
				Water.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lotad Builder only waiting for a Level
		/// </summary>
		public LotadInstance(int level)
		: base(
				SpeciesLotad.Instance, // PokemonInstance Species
				"Lotad", level,
				Water.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lotad Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public LotadInstance() : base(
			SpeciesLotad.Instance, // PokemonInstance Species
			Water.Instance, Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}