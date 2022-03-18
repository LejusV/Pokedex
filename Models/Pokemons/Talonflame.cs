using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Talonflame Species to store common natural stats of all Talonflames
	#region SpeciesTalonflame
	public class SpeciesTalonflame : PokemonSpecies
	{
#nullable enable
		private static SpeciesTalonflame? _instance = null;
#nullable restore
        public static SpeciesTalonflame Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesTalonflame();
                }
                return _instance;
            }
        }

		#region SpeciesTalonflame Constructor
		public SpeciesTalonflame() : base(
			663,
			"Talonflame",
			1.2,
			24.5,
			78, // HPs
			81, 71, // Attack & Defense
			74, 69, // Special Attack & Defense
			126		
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
				"Razor-Wind",
				"Swords-Dance",
				"Fly",
				"Tackle",
				"Growl",
				"Ember",
				"Flamethrower",
				"Hyper-Beam",
				"Peck",
				"Solar-Beam",
				"Toxic",
				"Agility",
				"Quick-Attack",
				"Double-Team",
				"Fire-Blast",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Flail",
				"Protect",
				"Swagger",
				"Steel-Wing",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Sunny-Day",
				"Heat-Wave",
				"Will-O-Wisp",
				"Facade",
				"Taunt",
				"Snatch",
				"Secret-Power",
				"Overheat",
				"Aerial-Ace",
				"Bulk-Up",
				"Roost",
				"Natural-Gift",
				"Tailwind",
				"U-Turn",
				"Me-First",
				"Flare-Blitz",
				"Brave-Bird",
				"Giga-Impact",
				"Hone-Claws",
				"Flame-Charge",
				"Round",
				"Incinerate",
				"Acrobatics",
				"Work-Up",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Talonflame PokemonInstance Class
	#region Talonflame
	public class TalonflameInstance : PokemonInstance
	{
		#region Talonflame Constructors
		/// <summary>
		/// Talonflame Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public TalonflameInstance(string nickname, int level)
		: base(
				SpeciesTalonflame.Instance, // Pokemon Species
				nickname, level,
				Fire.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Talonflame Builder only waiting for a Level
		/// </summary>
		public TalonflameInstance(int level)
		: base(
				SpeciesTalonflame.Instance, // PokemonInstance Species
				"Talonflame", level,
				Fire.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Talonflame Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public TalonflameInstance() : base(
			SpeciesTalonflame.Instance, // PokemonInstance Species
			Fire.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}