using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Eevee Species to store common natural stats of all Eevees
	#region SpeciesEevee
	public class SpeciesEevee : PokemonSpecies
	{
#nullable enable
		private static SpeciesEevee? _instance = null;
#nullable restore
        public static SpeciesEevee Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesEevee();
                }
                return _instance;
            }
        }

		#region SpeciesEevee Constructor
		public SpeciesEevee() : base(
			"Eevee",
			0.3,
			6.5,
			55, // HPs
			55, 50, // Attack & Defense
			45, 65, // Special Attack & Defense
			55		
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
				"Sand-Attack",
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Tail-Whip",
				"Bite",
				"Growl",
				"Dig",
				"Toxic",
				"Quick-Attack",
				"Rage",
				"Mimic",
				"Double-Team",
				"Reflect",
				"Focus-Energy",
				"Bide",
				"Swift",
				"Skull-Bash",
				"Rest",
				"Substitute",
				"Snore",
				"Curse",
				"Flail",
				"Protect",
				"Mud-Slap",
				"Detect",
				"Endure",
				"Charm",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Frustration",
				"Baton-Pass",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Shadow-Ball",
				"Facade",
				"Helping-Hand",
				"Wish",
				"Yawn",
				"Refresh",
				"Secret-Power",
				"Hyper-Voice",
				"Fake-Tears",
				"Tickle",
				"Covet",
				"Natural-Gift",
				"Trump-Card",
				"Last-Resort",
				"Captivate",
				"Synchronoise",
				"Round",
				"Echoed-Voice",
				"Stored-Power",
				"Retaliate",
				"Work-Up",
				"Confide",
				"Baby-Doll-Eyes"
			};
		}
		#endregion
	}
	#endregion

	//Eevee PokemonInstance Class
	#region Eevee
	public class EeveeInstance : PokemonInstance
	{
		#region Eevee Constructors
		/// <summary>
		/// Eevee Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public EeveeInstance(string nickname, int level)
		: base(
				133,
				SpeciesEevee.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Eevee Builder only waiting for a Level
		/// </summary>
		public EeveeInstance(int level)
		: base(
				133,
				SpeciesEevee.Instance, // PokemonInstance Species
				"Eevee", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Eevee Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Eevee() : base(
			133,
			SpeciesEevee.Instance, // PokemonInstance Species
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}