using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Ninetales Species to store common natural stats of all Ninetaless
	#region SpeciesNinetales
	public class SpeciesNinetales : PokemonSpecies
	{
#nullable enable
		private static SpeciesNinetales? _instance = null;
#nullable restore
        public static SpeciesNinetales Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesNinetales();
                }
                return _instance;
            }
        }

		#region SpeciesNinetales Constructor
		public SpeciesNinetales() : base(
			38,
			"Ninetales",
			1.1,
			19.9,
			73, // HPs
			76, 75, // Attack & Defense
			81, 100, // Special Attack & Defense
			100		
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
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Tail-Whip",
				"Roar",
				"Ember",
				"Flamethrower",
				"Hyper-Beam",
				"Solar-Beam",
				"Fire-Spin",
				"Dig",
				"Toxic",
				"Quick-Attack",
				"Rage",
				"Mimic",
				"Double-Team",
				"Confuse-Ray",
				"Reflect",
				"Bide",
				"Fire-Blast",
				"Swift",
				"Skull-Bash",
				"Dream-Eater",
				"Rest",
				"Substitute",
				"Snore",
				"Curse",
				"Spite",
				"Protect",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Pain-Split",
				"Iron-Tail",
				"Hidden-Power",
				"Sunny-Day",
				"Psych-Up",
				"Heat-Wave",
				"Will-O-Wisp",
				"Facade",
				"Role-Play",
				"Imprison",
				"Secret-Power",
				"Overheat",
				"Covet",
				"Calm-Mind",
				"Natural-Gift",
				"Payback",
				"Dark-Pulse",
				"Energy-Ball",
				"Giga-Impact",
				"Nasty-Plot",
				"Zen-Headbutt",
				"Captivate",
				"Ominous-Wind",
				"Psyshock",
				"Flame-Charge",
				"Foul-Play",
				"Round",
				"Incinerate",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Ninetales PokemonInstance Class
	#region Ninetales
	public class NinetalesInstance : PokemonInstance
	{
		#region Ninetales Constructors
		/// <summary>
		/// Ninetales Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public NinetalesInstance(string nickname, int level)
		: base(
				SpeciesNinetales.Instance, // Pokemon Species
				nickname, level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ninetales Builder only waiting for a Level
		/// </summary>
		public NinetalesInstance(int level)
		: base(
				SpeciesNinetales.Instance, // PokemonInstance Species
				"Ninetales", level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ninetales Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public NinetalesInstance() : base(
			SpeciesNinetales.Instance, // PokemonInstance Species
			Fire.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}