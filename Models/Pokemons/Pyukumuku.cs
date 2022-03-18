using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Pyukumuku Species to store common natural stats of all Pyukumukus
	#region SpeciesPyukumuku
	public class SpeciesPyukumuku : PokemonSpecies
	{
#nullable enable
		private static SpeciesPyukumuku? _instance = null;
#nullable restore
        public static SpeciesPyukumuku Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesPyukumuku();
                }
                return _instance;
            }
        }

		#region SpeciesPyukumuku Constructor
		public SpeciesPyukumuku() : base(
			771,
			"Pyukumuku",
			0.3,
			1.2,
			55, // HPs
			60, 130, // Attack & Defense
			30, 130, // Special Attack & Defense
			5		
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
				"Counter",
				"Toxic",
				"Double-Team",
				"Recover",
				"Harden",
				"Light-Screen",
				"Reflect",
				"Bide",
				"Rest",
				"Substitute",
				"Curse",
				"Spite",
				"Protect",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Safeguard",
				"Pain-Split",
				"Baton-Pass",
				"Rain-Dance",
				"Psych-Up",
				"Hail",
				"Memento",
				"Taunt",
				"Helping-Hand",
				"Mud-Sport",
				"Tickle",
				"Water-Sport",
				"Gastro-Acid",
				"Soak",
				"Quash",
				"Bestow",
				"Confide",
				"Venom-Drench",
				"Purify"
			};
		}
		#endregion
	}
	#endregion

	//Pyukumuku PokemonInstance Class
	#region Pyukumuku
	public class PyukumukuInstance : PokemonInstance
	{
		#region Pyukumuku Constructors
		/// <summary>
		/// Pyukumuku Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public PyukumukuInstance(string nickname, int level)
		: base(
				SpeciesPyukumuku.Instance, // Pokemon Species
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pyukumuku Builder only waiting for a Level
		/// </summary>
		public PyukumukuInstance(int level)
		: base(
				SpeciesPyukumuku.Instance, // PokemonInstance Species
				"Pyukumuku", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pyukumuku Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public PyukumukuInstance() : base(
			SpeciesPyukumuku.Instance, // PokemonInstance Species
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}