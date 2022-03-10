using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Eelektrik Species to store common natural stats of all Eelektriks
	#region SpeciesEelektrik
	public class SpeciesEelektrik : PokemonSpecies
	{
#nullable enable
		private static SpeciesEelektrik? _instance = null;
#nullable restore
        public static SpeciesEelektrik Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesEelektrik();
                }
                return _instance;
            }
        }

		#region SpeciesEelektrik Constructor
		public SpeciesEelektrik() : base(
			"Eelektrik",
			1.2,
			22.0,
			65, // HPs
			85, 70, // Attack & Defense
			75, 70, // Special Attack & Defense
			40		
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
				"Bind",
				"Headbutt",
				"Thrash",
				"Acid",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Double-Team",
				"Light-Screen",
				"Flash",
				"Rest",
				"Super-Fang",
				"Substitute",
				"Snore",
				"Protect",
				"Zap-Cannon",
				"Giga-Drain",
				"Swagger",
				"Spark",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Crunch",
				"Facade",
				"Knock-Off",
				"Secret-Power",
				"Signal-Beam",
				"Bounce",
				"Shock-Wave",
				"U-Turn",
				"Gastro-Acid",
				"Magnet-Rise",
				"Aqua-Tail",
				"Flash-Cannon",
				"Discharge",
				"Charge-Beam",
				"Coil",
				"Acid-Spray",
				"Round",
				"Acrobatics",
				"Volt-Switch",
				"Wild-Charge",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Eelektrik PokemonInstance Class
	#region Eelektrik
	public class EelektrikInstance : PokemonInstance
	{
		#region Eelektrik Constructors
		/// <summary>
		/// Eelektrik Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public EelektrikInstance(string nickname, int level)
		: base(
				603,
				SpeciesEelektrik.Instance, // Pokemon Species
				nickname, level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Eelektrik Builder only waiting for a Level
		/// </summary>
		public EelektrikInstance(int level)
		: base(
				603,
				SpeciesEelektrik.Instance, // PokemonInstance Species
				"Eelektrik", level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Eelektrik Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Eelektrik() : base(
			603,
			SpeciesEelektrik.Instance, // PokemonInstance Species
			Electric.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}