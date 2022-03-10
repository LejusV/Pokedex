using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Spheal Species to store common natural stats of all Spheals
	#region SpeciesSpheal
	public class SpeciesSpheal : PokemonSpecies
	{
#nullable enable
		private static SpeciesSpheal? _instance = null;
#nullable restore
        public static SpeciesSpheal Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesSpheal();
                }
                return _instance;
            }
        }

		#region SpeciesSpheal Constructor
		public SpeciesSpheal() : base(
			"Spheal",
			0.8,
			39.5,
			70, // HPs
			40, 50, // Attack & Defense
			55, 50, // Special Attack & Defense
			25		
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
				"Water-Gun",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Aurora-Beam",
				"Strength",
				"Earthquake",
				"Fissure",
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
				"Curse",
				"Powder-Snow",
				"Protect",
				"Belly-Drum",
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
				"Stockpile",
				"Spit-Up",
				"Swallow",
				"Hail",
				"Facade",
				"Yawn",
				"Secret-Power",
				"Dive",
				"Ice-Ball",
				"Rock-Tomb",
				"Signal-Beam",
				"Sheer-Cold",
				"Water-Sport",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"Aqua-Ring",
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

	//Spheal PokemonInstance Class
	#region Spheal
	public class SphealInstance : PokemonInstance
	{
		#region Spheal Constructors
		/// <summary>
		/// Spheal Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public SphealInstance(string nickname, int level)
		: base(
				363,
				SpeciesSpheal.Instance, // Pokemon Species
				nickname, level,
				Ice.Instance, Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Spheal Builder only waiting for a Level
		/// </summary>
		public SphealInstance(int level)
		: base(
				363,
				SpeciesSpheal.Instance, // PokemonInstance Species
				"Spheal", level,
				Ice.Instance, Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Spheal Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Spheal() : base(
			363,
			SpeciesSpheal.Instance, // PokemonInstance Species
			Ice.Instance, Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}