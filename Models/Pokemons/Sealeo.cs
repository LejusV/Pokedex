using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Sealeo Species to store common natural stats of all Sealeos
	#region SpeciesSealeo
	public class SpeciesSealeo : PokemonSpecies
	{
#nullable enable
		private static SpeciesSealeo? _instance = null;
#nullable restore
        public static SpeciesSealeo Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesSealeo();
                }
                return _instance;
            }
        }

		#region SpeciesSealeo Constructor
		public SpeciesSealeo() : base(
			364,
			"Sealeo",
			1.1,
			87.6,
			90, // HPs
			60, 70, // Attack & Defense
			75, 70, // Special Attack & Defense
			45		
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
				"Growl",
				"Roar",
				"Water-Gun",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Aurora-Beam",
				"Strength",
				"Earthquake",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Waterfall",
				"Rest",
				"Rock-Slide",
				"Super-Fang",
				"Substitute",
				"Snore",
				"Powder-Snow",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Encore",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Rock-Smash",
				"Whirlpool",
				"Hail",
				"Facade",
				"Secret-Power",
				"Dive",
				"Ice-Ball",
				"Rock-Tomb",
				"Signal-Beam",
				"Sheer-Cold",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"Aqua-Tail",
				"Captivate",
				"Round",
				"Echoed-Voice",
				"Bulldoze",
				"Frost-Breath",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Sealeo PokemonInstance Class
	#region Sealeo
	public class SealeoInstance : PokemonInstance
	{
		#region Sealeo Constructors
		/// <summary>
		/// Sealeo Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public SealeoInstance(string nickname, int level)
		: base(
				SpeciesSealeo.Instance, // Pokemon Species
				nickname, level,
				Ice.Instance, Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sealeo Builder only waiting for a Level
		/// </summary>
		public SealeoInstance(int level)
		: base(
				SpeciesSealeo.Instance, // PokemonInstance Species
				"Sealeo", level,
				Ice.Instance, Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sealeo Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public SealeoInstance() : base(
			SpeciesSealeo.Instance, // PokemonInstance Species
			Ice.Instance, Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}