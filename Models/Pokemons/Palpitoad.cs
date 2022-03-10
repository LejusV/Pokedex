using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Palpitoad Species to store common natural stats of all Palpitoads
	#region SpeciesPalpitoad
	public class SpeciesPalpitoad : PokemonSpecies
	{
#nullable enable
		private static SpeciesPalpitoad? _instance = null;
#nullable restore
        public static SpeciesPalpitoad Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesPalpitoad();
                }
                return _instance;
            }
        }

		#region SpeciesPalpitoad Constructor
		public SpeciesPalpitoad() : base(
			"Palpitoad",
			0.8,
			17.0,
			75, // HPs
			65, 55, // Attack & Defense
			65, 55, // Special Attack & Defense
			69		
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
				"Growl",
				"Supersonic",
				"Hydro-Pump",
				"Surf",
				"Bubble-Beam",
				"Toxic",
				"Double-Team",
				"Bubble",
				"Rest",
				"Substitute",
				"Snore",
				"Flail",
				"Protect",
				"Sludge-Bomb",
				"Icy-Wind",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Rain-Dance",
				"Rock-Smash",
				"Uproar",
				"Hail",
				"Facade",
				"Focus-Punch",
				"Endeavor",
				"Secret-Power",
				"Hyper-Voice",
				"Muddy-Water",
				"Bounce",
				"Mud-Shot",
				"Water-Pulse",
				"Gastro-Acid",
				"Aqua-Ring",
				"Earth-Power",
				"Stealth-Rock",
				"Sludge-Wave",
				"After-You",
				"Round",
				"Echoed-Voice",
				"Scald",
				"Bulldoze",
				"Confide",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion

	//Palpitoad PokemonInstance Class
	#region Palpitoad
	public class PalpitoadInstance : PokemonInstance
	{
		#region Palpitoad Constructors
		/// <summary>
		/// Palpitoad Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public PalpitoadInstance(string nickname, int level)
		: base(
				536,
				SpeciesPalpitoad.Instance, // Pokemon Species
				nickname, level,
				Water.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Palpitoad Builder only waiting for a Level
		/// </summary>
		public PalpitoadInstance(int level)
		: base(
				536,
				SpeciesPalpitoad.Instance, // PokemonInstance Species
				"Palpitoad", level,
				Water.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Palpitoad Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Palpitoad() : base(
			536,
			SpeciesPalpitoad.Instance, // PokemonInstance Species
			Water.Instance, Ground.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}