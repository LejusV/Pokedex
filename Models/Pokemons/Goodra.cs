using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Goodra Species to store common natural stats of all Goodras
	#region SpeciesGoodra
	public class SpeciesGoodra : PokemonSpecies
	{
#nullable enable
		private static SpeciesGoodra? _instance = null;
#nullable restore
        public static SpeciesGoodra Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesGoodra();
                }
                return _instance;
            }
        }

		#region SpeciesGoodra Constructor
		public SpeciesGoodra() : base(
			"Goodra",
			2.0,
			150.5,
			90, // HPs
			100, 70, // Attack & Defense
			110, 150, // Special Attack & Defense
			80		
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
				"Fire-Punch",
				"Thunder-Punch",
				"Tackle",
				"Body-Slam",
				"Flamethrower",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Strength",
				"Absorb",
				"Thunderbolt",
				"Thunder",
				"Earthquake",
				"Toxic",
				"Double-Team",
				"Bide",
				"Fire-Blast",
				"Bubble",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Flail",
				"Protect",
				"Sludge-Bomb",
				"Outrage",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dragon-Breath",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Rock-Smash",
				"Hail",
				"Facade",
				"Focus-Punch",
				"Superpower",
				"Secret-Power",
				"Muddy-Water",
				"Shock-Wave",
				"Water-Pulse",
				"Feint",
				"Aqua-Tail",
				"Dragon-Pulse",
				"Focus-Blast",
				"Giga-Impact",
				"Draco-Meteor",
				"Power-Whip",
				"Sludge-Wave",
				"Round",
				"Incinerate",
				"Bulldoze",
				"Dragon-Tail",
				"Confide",
				"Infestation",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion

	//Goodra PokemonInstance Class
	#region Goodra
	public class GoodraInstance : PokemonInstance
	{
		#region Goodra Constructors
		/// <summary>
		/// Goodra Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public GoodraInstance(string nickname, int level)
		: base(
				706,
				SpeciesGoodra.Instance, // Pokemon Species
				nickname, level,
				Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Goodra Builder only waiting for a Level
		/// </summary>
		public GoodraInstance(int level)
		: base(
				706,
				SpeciesGoodra.Instance, // PokemonInstance Species
				"Goodra", level,
				Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Goodra Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Goodra() : base(
			706,
			SpeciesGoodra.Instance, // PokemonInstance Species
			Dragon.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}