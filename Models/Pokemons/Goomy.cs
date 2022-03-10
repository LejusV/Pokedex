using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Goomy Species to store common natural stats of all Goomys
	#region SpeciesGoomy
	public class SpeciesGoomy : PokemonSpecies
	{
#nullable enable
		private static SpeciesGoomy? _instance = null;
#nullable restore
        public static SpeciesGoomy Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesGoomy();
                }
                return _instance;
            }
        }

		#region SpeciesGoomy Constructor
		public SpeciesGoomy() : base(
			"Goomy",
			0.3,
			2.8,
			45, // HPs
			50, 35, // Attack & Defense
			55, 75, // Special Attack & Defense
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
				"Tackle",
				"Body-Slam",
				"Counter",
				"Absorb",
				"Thunderbolt",
				"Toxic",
				"Double-Team",
				"Bide",
				"Bubble",
				"Acid-Armor",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Curse",
				"Flail",
				"Protect",
				"Sludge-Bomb",
				"Outrage",
				"Endure",
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
				"Facade",
				"Secret-Power",
				"Muddy-Water",
				"Poison-Tail",
				"Shock-Wave",
				"Water-Pulse",
				"Dragon-Pulse",
				"Draco-Meteor",
				"Sludge-Wave",
				"Round",
				"Confide",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion

	//Goomy PokemonInstance Class
	#region Goomy
	public class GoomyInstance : PokemonInstance
	{
		#region Goomy Constructors
		/// <summary>
		/// Goomy Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public GoomyInstance(string nickname, int level)
		: base(
				704,
				SpeciesGoomy.Instance, // Pokemon Species
				nickname, level,
				Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Goomy Builder only waiting for a Level
		/// </summary>
		public GoomyInstance(int level)
		: base(
				704,
				SpeciesGoomy.Instance, // PokemonInstance Species
				"Goomy", level,
				Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Goomy Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Goomy() : base(
			704,
			SpeciesGoomy.Instance, // PokemonInstance Species
			Dragon.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}