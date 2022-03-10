using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Venonat Species to store common natural stats of all Venonats
	#region SpeciesVenonat
	public class SpeciesVenonat : PokemonSpecies
	{
#nullable enable
		private static SpeciesVenonat? _instance = null;
#nullable restore
        public static SpeciesVenonat Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesVenonat();
                }
                return _instance;
            }
        }

		#region SpeciesVenonat Constructor
		public SpeciesVenonat() : base(
			"Venonat",
			1.0,
			30.0,
			60, // HPs
			55, 50, // Attack & Defense
			40, 55, // Special Attack & Defense
			45		
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
				"Take-Down",
				"Double-Edge",
				"Supersonic",
				"Disable",
				"Psybeam",
				"Mega-Drain",
				"Solar-Beam",
				"Poison-Powder",
				"Stun-Spore",
				"Sleep-Powder",
				"String-Shot",
				"Toxic",
				"Confusion",
				"Psychic",
				"Agility",
				"Rage",
				"Mimic",
				"Screech",
				"Double-Team",
				"Reflect",
				"Bide",
				"Swift",
				"Leech-Life",
				"Flash",
				"Psywave",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Protect",
				"Sludge-Bomb",
				"Foresight",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Baton-Pass",
				"Sweet-Scent",
				"Morning-Sun",
				"Hidden-Power",
				"Sunny-Day",
				"Facade",
				"Skill-Swap",
				"Secret-Power",
				"Poison-Fang",
				"Signal-Beam",
				"Natural-Gift",
				"Toxic-Spikes",
				"Zen-Headbutt",
				"Captivate",
				"Bug-Bite",
				"Venoshock",
				"Rage-Powder",
				"Round",
				"Struggle-Bug",
				"Confide",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion

	//Venonat PokemonInstance Class
	#region Venonat
	public class VenonatInstance : PokemonInstance
	{
		#region Venonat Constructors
		/// <summary>
		/// Venonat Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public VenonatInstance(string nickname, int level)
		: base(
				48,
				SpeciesVenonat.Instance, // Pokemon Species
				nickname, level,
				Bug.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Venonat Builder only waiting for a Level
		/// </summary>
		public VenonatInstance(int level)
		: base(
				48,
				SpeciesVenonat.Instance, // PokemonInstance Species
				"Venonat", level,
				Bug.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Venonat Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Venonat() : base(
			48,
			SpeciesVenonat.Instance, // PokemonInstance Species
			Bug.Instance, Poison.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}