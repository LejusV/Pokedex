using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Mudbray Species to store common natural stats of all Mudbrays
	#region SpeciesMudbray
	public class SpeciesMudbray : PokemonSpecies
	{
#nullable enable
		private static SpeciesMudbray? _instance = null;
#nullable restore
        public static SpeciesMudbray Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesMudbray();
                }
                return _instance;
            }
        }

		#region SpeciesMudbray Constructor
		public SpeciesMudbray() : base(
			749,
			"Mudbray",
			1.0,
			110.0,
			70, // HPs
			100, 70, // Attack & Defense
			45, 55, // Special Attack & Defense
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
				"Stomp",
				"Double-Kick",
				"Mega-Kick",
				"Body-Slam",
				"Double-Edge",
				"Roar",
				"Counter",
				"Earthquake",
				"Toxic",
				"Double-Team",
				"Bide",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Protect",
				"Mud-Slap",
				"Sandstorm",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Magnitude",
				"Hidden-Power",
				"Facade",
				"Superpower",
				"Mud-Sport",
				"Rock-Tomb",
				"Iron-Defense",
				"Close-Combat",
				"Payback",
				"Mud-Bomb",
				"Heavy-Slam",
				"Low-Sweep",
				"Round",
				"Bulldoze",
				"Rototiller",
				"Confide",
				"High-Horsepower"
			};
		}
		#endregion
	}
	#endregion

	//Mudbray PokemonInstance Class
	#region Mudbray
	public class MudbrayInstance : PokemonInstance
	{
		#region Mudbray Constructors
		/// <summary>
		/// Mudbray Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public MudbrayInstance(string nickname, int level)
		: base(
				SpeciesMudbray.Instance, // Pokemon Species
				nickname, level,
				Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mudbray Builder only waiting for a Level
		/// </summary>
		public MudbrayInstance(int level)
		: base(
				SpeciesMudbray.Instance, // PokemonInstance Species
				"Mudbray", level,
				Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mudbray Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public MudbrayInstance() : base(
			SpeciesMudbray.Instance, // PokemonInstance Species
			Ground.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}