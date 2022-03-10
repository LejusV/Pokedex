using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Dewpider Species to store common natural stats of all Dewpiders
	#region SpeciesDewpider
	public class SpeciesDewpider : PokemonSpecies
	{
#nullable enable
		private static SpeciesDewpider? _instance = null;
#nullable restore
        public static SpeciesDewpider Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesDewpider();
                }
                return _instance;
            }
        }

		#region SpeciesDewpider Constructor
		public SpeciesDewpider() : base(
			"Dewpider",
			0.3,
			4.0,
			38, // HPs
			40, 52, // Attack & Defense
			40, 72, // Special Attack & Defense
			27		
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
				"Bite",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Aurora-Beam",
				"Toxic",
				"Double-Team",
				"Waterfall",
				"Leech-Life",
				"Bubble",
				"Rest",
				"Substitute",
				"Spider-Web",
				"Protect",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Rain-Dance",
				"Crunch",
				"Mirror-Coat",
				"Stockpile",
				"Spit-Up",
				"Facade",
				"Water-Sport",
				"Aqua-Ring",
				"Poison-Jab",
				"X-Scissor",
				"Bug-Bite",
				"Power-Split",
				"Entrainment",
				"Round",
				"Scald",
				"Frost-Breath",
				"Sticky-Web",
				"Confide",
				"Infestation",
				"Lunge",
				"Liquidation"
			};
		}
		#endregion
	}
	#endregion

	//Dewpider PokemonInstance Class
	#region Dewpider
	public class DewpiderInstance : PokemonInstance
	{
		#region Dewpider Constructors
		/// <summary>
		/// Dewpider Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public DewpiderInstance(string nickname, int level)
		: base(
				751,
				SpeciesDewpider.Instance, // Pokemon Species
				nickname, level,
				Water.Instance, Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dewpider Builder only waiting for a Level
		/// </summary>
		public DewpiderInstance(int level)
		: base(
				751,
				SpeciesDewpider.Instance, // PokemonInstance Species
				"Dewpider", level,
				Water.Instance, Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dewpider Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Dewpider() : base(
			751,
			SpeciesDewpider.Instance, // PokemonInstance Species
			Water.Instance, Bug.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}