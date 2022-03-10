using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Pyroar Species to store common natural stats of all Pyroars
	#region SpeciesPyroar
	public class SpeciesPyroar : PokemonSpecies
	{
#nullable enable
		private static SpeciesPyroar? _instance = null;
#nullable restore
        public static SpeciesPyroar Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesPyroar();
                }
                return _instance;
            }
        }

		#region SpeciesPyroar Constructor
		public SpeciesPyroar() : base(
			"Pyroar",
			1.5,
			81.5,
			86, // HPs
			68, 72, // Attack & Defense
			109, 66, // Special Attack & Defense
			106		
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
				"Hyper-Beam",
				"Strength",
				"Solar-Beam",
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
				"Endeavor",
				"Snatch",
				"Secret-Power",
				"Hyper-Voice",
				"Overheat",
				"Bounce",
				"Payback",
				"Dark-Pulse",
				"Giga-Impact",
				"Fire-Fang",
				"Flame-Charge",
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

	//Pyroar PokemonInstance Class
	#region Pyroar
	public class PyroarInstance : PokemonInstance
	{
		#region Pyroar Constructors
		/// <summary>
		/// Pyroar Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public PyroarInstance(string nickname, int level)
		: base(
				668,
				SpeciesPyroar.Instance, // Pokemon Species
				nickname, level,
				Fire.Instance, Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pyroar Builder only waiting for a Level
		/// </summary>
		public PyroarInstance(int level)
		: base(
				668,
				SpeciesPyroar.Instance, // PokemonInstance Species
				"Pyroar", level,
				Fire.Instance, Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pyroar Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Pyroar() : base(
			668,
			SpeciesPyroar.Instance, // PokemonInstance Species
			Fire.Instance, Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}