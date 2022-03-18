using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Sliggoo Species to store common natural stats of all Sliggoos
	#region SpeciesSliggoo
	public class SpeciesSliggoo : PokemonSpecies
	{
#nullable enable
		private static SpeciesSliggoo? _instance = null;
#nullable restore
        public static SpeciesSliggoo Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesSliggoo();
                }
                return _instance;
            }
        }

		#region SpeciesSliggoo Constructor
		public SpeciesSliggoo() : base(
			705,
			"Sliggoo",
			0.8,
			17.5,
			68, // HPs
			75, 53, // Attack & Defense
			83, 113, // Special Attack & Defense
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
				"Body-Slam",
				"Ice-Beam",
				"Blizzard",
				"Absorb",
				"Thunderbolt",
				"Toxic",
				"Double-Team",
				"Bide",
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
				"Facade",
				"Secret-Power",
				"Muddy-Water",
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

	//Sliggoo PokemonInstance Class
	#region Sliggoo
	public class SliggooInstance : PokemonInstance
	{
		#region Sliggoo Constructors
		/// <summary>
		/// Sliggoo Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public SliggooInstance(string nickname, int level)
		: base(
				SpeciesSliggoo.Instance, // Pokemon Species
				nickname, level,
				Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sliggoo Builder only waiting for a Level
		/// </summary>
		public SliggooInstance(int level)
		: base(
				SpeciesSliggoo.Instance, // PokemonInstance Species
				"Sliggoo", level,
				Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sliggoo Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public SliggooInstance() : base(
			SpeciesSliggoo.Instance, // PokemonInstance Species
			Dragon.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}