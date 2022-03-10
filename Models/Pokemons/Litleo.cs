using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Litleo Species to store common natural stats of all Litleos
	#region SpeciesLitleo
	public class SpeciesLitleo : PokemonSpecies
	{
#nullable enable
		private static SpeciesLitleo? _instance = null;
#nullable restore
        public static SpeciesLitleo Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesLitleo();
                }
                return _instance;
            }
        }

		#region SpeciesLitleo Constructor
		public SpeciesLitleo() : base(
			"Litleo",
			0.6,
			13.5,
			62, // HPs
			50, 58, // Attack & Defense
			73, 54, // Special Attack & Defense
			72		
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
				"Headbutt",
				"Tackle",
				"Take-Down",
				"Leer",
				"Roar",
				"Ember",
				"Flamethrower",
				"Strength",
				"Solar-Beam",
				"Fire-Spin",
				"Dig",
				"Toxic",
				"Double-Team",
				"Fire-Blast",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Crunch",
				"Rock-Smash",
				"Heat-Wave",
				"Will-O-Wisp",
				"Facade",
				"Taunt",
				"Helping-Hand",
				"Yawn",
				"Endeavor",
				"Snatch",
				"Secret-Power",
				"Hyper-Voice",
				"Overheat",
				"Payback",
				"Flare-Blitz",
				"Dark-Pulse",
				"Fire-Fang",
				"Flame-Charge",
				"Entrainment",
				"Round",
				"Echoed-Voice",
				"Incinerate",
				"Retaliate",
				"Bulldoze",
				"Work-Up",
				"Wild-Charge",
				"Snarl",
				"Noble-Roar",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Litleo PokemonInstance Class
	#region Litleo
	public class LitleoInstance : PokemonInstance
	{
		#region Litleo Constructors
		/// <summary>
		/// Litleo Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public LitleoInstance(string nickname, int level)
		: base(
				667,
				SpeciesLitleo.Instance, // Pokemon Species
				nickname, level,
				Fire.Instance, Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Litleo Builder only waiting for a Level
		/// </summary>
		public LitleoInstance(int level)
		: base(
				667,
				SpeciesLitleo.Instance, // PokemonInstance Species
				"Litleo", level,
				Fire.Instance, Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Litleo Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Litleo() : base(
			667,
			SpeciesLitleo.Instance, // PokemonInstance Species
			Fire.Instance, Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}