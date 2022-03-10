using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Tynamo Species to store common natural stats of all Tynamos
	#region SpeciesTynamo
	public class SpeciesTynamo : PokemonSpecies
	{
#nullable enable
		private static SpeciesTynamo? _instance = null;
#nullable restore
        public static SpeciesTynamo Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesTynamo();
                }
                return _instance;
            }
        }

		#region SpeciesTynamo Constructor
		public SpeciesTynamo() : base(
			"Tynamo",
			0.2,
			0.3,
			35, // HPs
			55, 40, // Attack & Defense
			45, 40, // Special Attack & Defense
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
				"Tackle",
				"Thunder-Wave",
				"Spark",
				"Magnet-Rise",
				"Charge-Beam"
			};
		}
		#endregion
	}
	#endregion

	//Tynamo PokemonInstance Class
	#region Tynamo
	public class TynamoInstance : PokemonInstance
	{
		#region Tynamo Constructors
		/// <summary>
		/// Tynamo Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public TynamoInstance(string nickname, int level)
		: base(
				602,
				SpeciesTynamo.Instance, // Pokemon Species
				nickname, level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tynamo Builder only waiting for a Level
		/// </summary>
		public TynamoInstance(int level)
		: base(
				602,
				SpeciesTynamo.Instance, // PokemonInstance Species
				"Tynamo", level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tynamo Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Tynamo() : base(
			602,
			SpeciesTynamo.Instance, // PokemonInstance Species
			Electric.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}