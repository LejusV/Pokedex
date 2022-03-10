using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Combee Species to store common natural stats of all Combees
	#region SpeciesCombee
	public class SpeciesCombee : PokemonSpecies
	{
#nullable enable
		private static SpeciesCombee? _instance = null;
#nullable restore
        public static SpeciesCombee Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesCombee();
                }
                return _instance;
            }
        }

		#region SpeciesCombee Constructor
		public SpeciesCombee() : base(
			"Combee",
			0.3,
			5.5,
			30, // HPs
			30, 42, // Attack & Defense
			30, 42, // Special Attack & Defense
			70		
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
				"Gust",
				"String-Shot",
				"Swift",
				"Snore",
				"Mud-Slap",
				"Sweet-Scent",
				"Endeavor",
				"Air-Cutter",
				"Tailwind",
				"Bug-Buzz",
				"Bug-Bite",
				"Ominous-Wind"
			};
		}
		#endregion
	}
	#endregion

	//Combee PokemonInstance Class
	#region Combee
	public class CombeeInstance : PokemonInstance
	{
		#region Combee Constructors
		/// <summary>
		/// Combee Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public CombeeInstance(string nickname, int level)
		: base(
				415,
				SpeciesCombee.Instance, // Pokemon Species
				nickname, level,
				Bug.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Combee Builder only waiting for a Level
		/// </summary>
		public CombeeInstance(int level)
		: base(
				415,
				SpeciesCombee.Instance, // PokemonInstance Species
				"Combee", level,
				Bug.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Combee Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Combee() : base(
			415,
			SpeciesCombee.Instance, // PokemonInstance Species
			Bug.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}