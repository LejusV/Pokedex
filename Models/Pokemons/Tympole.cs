using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Tympole Species to store common natural stats of all Tympoles
	#region SpeciesTympole
	public class SpeciesTympole : PokemonSpecies
	{
#nullable enable
		private static SpeciesTympole? _instance = null;
#nullable restore
        public static SpeciesTympole Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesTympole();
                }
                return _instance;
            }
        }

		#region SpeciesTympole Constructor
		public SpeciesTympole() : base(
			535,
			"Tympole",
			0.5,
			4.5,
			50, // HPs
			50, 40, // Attack & Defense
			50, 40, // Special Attack & Defense
			64		
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
				"Mist",
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
				"Uproar",
				"Hail",
				"Facade",
				"Endeavor",
				"Refresh",
				"Secret-Power",
				"Mud-Sport",
				"Hyper-Voice",
				"Muddy-Water",
				"Bounce",
				"Mud-Shot",
				"Water-Pulse",
				"Aqua-Ring",
				"Earth-Power",
				"Mud-Bomb",
				"Sludge-Wave",
				"After-You",
				"Round",
				"Echoed-Voice",
				"Scald",
				"Confide",
				"Venom-Drench",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion

	//Tympole PokemonInstance Class
	#region Tympole
	public class TympoleInstance : PokemonInstance
	{
		#region Tympole Constructors
		/// <summary>
		/// Tympole Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public TympoleInstance(string nickname, int level)
		: base(
				SpeciesTympole.Instance, // Pokemon Species
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tympole Builder only waiting for a Level
		/// </summary>
		public TympoleInstance(int level)
		: base(
				SpeciesTympole.Instance, // PokemonInstance Species
				"Tympole", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tympole Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public TympoleInstance() : base(
			SpeciesTympole.Instance, // PokemonInstance Species
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}