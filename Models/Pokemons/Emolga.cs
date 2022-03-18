using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Emolga Species to store common natural stats of all Emolgas
	#region SpeciesEmolga
	public class SpeciesEmolga : PokemonSpecies
	{
#nullable enable
		private static SpeciesEmolga? _instance = null;
#nullable restore
        public static SpeciesEmolga Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesEmolga();
                }
                return _instance;
            }
        }

		#region SpeciesEmolga Constructor
		public SpeciesEmolga() : base(
			587,
			"Emolga",
			0.4,
			5.0,
			55, // HPs
			75, 60, // Attack & Defense
			75, 60, // Special Attack & Defense
			103		
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
				"Cut",
				"Tail-Whip",
				"Thunder-Shock",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Agility",
				"Quick-Attack",
				"Double-Team",
				"Light-Screen",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Charm",
				"Swagger",
				"Spark",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Baton-Pass",
				"Encore",
				"Pursuit",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Facade",
				"Charge",
				"Taunt",
				"Helping-Hand",
				"Knock-Off",
				"Secret-Power",
				"Astonish",
				"Tickle",
				"Signal-Beam",
				"Aerial-Ace",
				"Covet",
				"Shock-Wave",
				"Roost",
				"Tailwind",
				"U-Turn",
				"Fling",
				"Last-Resort",
				"Air-Slash",
				"Discharge",
				"Charge-Beam",
				"Electro-Ball",
				"Round",
				"Acrobatics",
				"Volt-Switch",
				"Electroweb",
				"Wild-Charge",
				"Ion-Deluge",
				"Confide",
				"Nuzzle",
				"Speed-Swap"
			};
		}
		#endregion
	}
	#endregion

	//Emolga PokemonInstance Class
	#region Emolga
	public class EmolgaInstance : PokemonInstance
	{
		#region Emolga Constructors
		/// <summary>
		/// Emolga Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public EmolgaInstance(string nickname, int level)
		: base(
				SpeciesEmolga.Instance, // Pokemon Species
				nickname, level,
				Electric.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Emolga Builder only waiting for a Level
		/// </summary>
		public EmolgaInstance(int level)
		: base(
				SpeciesEmolga.Instance, // PokemonInstance Species
				"Emolga", level,
				Electric.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Emolga Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public EmolgaInstance() : base(
			SpeciesEmolga.Instance, // PokemonInstance Species
			Electric.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}