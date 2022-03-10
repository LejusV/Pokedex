using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Snorunt Species to store common natural stats of all Snorunts
	#region SpeciesSnorunt
	public class SpeciesSnorunt : PokemonSpecies
	{
#nullable enable
		private static SpeciesSnorunt? _instance = null;
#nullable restore
        public static SpeciesSnorunt Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesSnorunt();
                }
                return _instance;
            }
        }

		#region SpeciesSnorunt Constructor
		public SpeciesSnorunt() : base(
			"Snorunt",
			0.7,
			16.8,
			50, // HPs
			50, 50, // Attack & Defense
			50, 50, // Special Attack & Defense
			50		
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
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Leer",
				"Bite",
				"Disable",
				"Ice-Beam",
				"Blizzard",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Light-Screen",
				"Bide",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Spite",
				"Powder-Snow",
				"Protect",
				"Spikes",
				"Icy-Wind",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Hidden-Power",
				"Rain-Dance",
				"Crunch",
				"Shadow-Ball",
				"Hail",
				"Facade",
				"Secret-Power",
				"Weather-Ball",
				"Fake-Tears",
				"Block",
				"Water-Pulse",
				"Natural-Gift",
				"Switcheroo",
				"Avalanche",
				"Ice-Shard",
				"Ice-Fang",
				"Captivate",
				"Round",
				"Hex",
				"Frost-Breath",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Snorunt PokemonInstance Class
	#region Snorunt
	public class SnoruntInstance : PokemonInstance
	{
		#region Snorunt Constructors
		/// <summary>
		/// Snorunt Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public SnoruntInstance(string nickname, int level)
		: base(
				361,
				SpeciesSnorunt.Instance, // Pokemon Species
				nickname, level,
				Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Snorunt Builder only waiting for a Level
		/// </summary>
		public SnoruntInstance(int level)
		: base(
				361,
				SpeciesSnorunt.Instance, // PokemonInstance Species
				"Snorunt", level,
				Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Snorunt Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Snorunt() : base(
			361,
			SpeciesSnorunt.Instance, // PokemonInstance Species
			Ice.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}