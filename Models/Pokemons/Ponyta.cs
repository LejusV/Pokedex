using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Ponyta Species to store common natural stats of all Ponytas
	#region SpeciesPonyta
	public class SpeciesPonyta : PokemonSpecies
	{
#nullable enable
		private static SpeciesPonyta? _instance = null;
#nullable restore
        public static SpeciesPonyta Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesPonyta();
                }
                return _instance;
            }
        }

		#region SpeciesPonyta Constructor
		public SpeciesPonyta() : base(
			"Ponyta",
			1.0,
			30.0,
			50, // HPs
			85, 55, // Attack & Defense
			65, 65, // Special Attack & Defense
			90		
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
				"Stomp",
				"Double-Kick",
				"Headbutt",
				"Horn-Drill",
				"Tackle",
				"Body-Slam",
				"Take-Down",
				"Thrash",
				"Double-Edge",
				"Tail-Whip",
				"Growl",
				"Ember",
				"Flamethrower",
				"Low-Kick",
				"Strength",
				"Solar-Beam",
				"Fire-Spin",
				"Toxic",
				"Hypnosis",
				"Agility",
				"Quick-Attack",
				"Rage",
				"Mimic",
				"Double-Team",
				"Reflect",
				"Bide",
				"Fire-Blast",
				"Swift",
				"Skull-Bash",
				"Rest",
				"Substitute",
				"Flame-Wheel",
				"Snore",
				"Curse",
				"Protect",
				"Endure",
				"Charm",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Morning-Sun",
				"Hidden-Power",
				"Sunny-Day",
				"Heat-Wave",
				"Will-O-Wisp",
				"Facade",
				"Secret-Power",
				"Overheat",
				"Bounce",
				"Natural-Gift",
				"Flare-Blitz",
				"Captivate",
				"Flame-Charge",
				"Round",
				"Echoed-Voice",
				"Ally-Switch",
				"Incinerate",
				"Inferno",
				"Wild-Charge",
				"Confide",
				"High-Horsepower"
			};
		}
		#endregion
	}
	#endregion

	//Ponyta PokemonInstance Class
	#region Ponyta
	public class PonytaInstance : PokemonInstance
	{
		#region Ponyta Constructors
		/// <summary>
		/// Ponyta Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public PonytaInstance(string nickname, int level)
		: base(
				77,
				SpeciesPonyta.Instance, // Pokemon Species
				nickname, level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ponyta Builder only waiting for a Level
		/// </summary>
		public PonytaInstance(int level)
		: base(
				77,
				SpeciesPonyta.Instance, // PokemonInstance Species
				"Ponyta", level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ponyta Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Ponyta() : base(
			77,
			SpeciesPonyta.Instance, // PokemonInstance Species
			Fire.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}