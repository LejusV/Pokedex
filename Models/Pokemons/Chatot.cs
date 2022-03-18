using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Chatot Species to store common natural stats of all Chatots
	#region SpeciesChatot
	public class SpeciesChatot : PokemonSpecies
	{
#nullable enable
		private static SpeciesChatot? _instance = null;
#nullable restore
        public static SpeciesChatot Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesChatot();
                }
                return _instance;
            }
        }

		#region SpeciesChatot Constructor
		public SpeciesChatot() : base(
			441,
			"Chatot",
			0.5,
			1.9,
			76, // HPs
			65, 45, // Attack & Defense
			92, 42, // Special Attack & Defense
			91		
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
				"Fly",
				"Fury-Attack",
				"Growl",
				"Sing",
				"Supersonic",
				"Peck",
				"Toxic",
				"Agility",
				"Night-Shade",
				"Mimic",
				"Double-Team",
				"Mirror-Move",
				"Swift",
				"Sky-Attack",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Endure",
				"Swagger",
				"Steel-Wing",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Encore",
				"Hidden-Power",
				"Twister",
				"Rain-Dance",
				"Sunny-Day",
				"Uproar",
				"Heat-Wave",
				"Torment",
				"Facade",
				"Taunt",
				"Role-Play",
				"Secret-Power",
				"Feather-Dance",
				"Hyper-Voice",
				"Air-Cutter",
				"Aerial-Ace",
				"Roost",
				"Natural-Gift",
				"Pluck",
				"Tailwind",
				"U-Turn",
				"Nasty-Plot",
				"Defog",
				"Captivate",
				"Chatter",
				"Ominous-Wind",
				"Synchronoise",
				"Round",
				"Echoed-Voice",
				"Work-Up",
				"Boomburst",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Chatot PokemonInstance Class
	#region Chatot
	public class ChatotInstance : PokemonInstance
	{
		#region Chatot Constructors
		/// <summary>
		/// Chatot Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ChatotInstance(string nickname, int level)
		: base(
				SpeciesChatot.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Chatot Builder only waiting for a Level
		/// </summary>
		public ChatotInstance(int level)
		: base(
				SpeciesChatot.Instance, // PokemonInstance Species
				"Chatot", level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Chatot Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public ChatotInstance() : base(
			SpeciesChatot.Instance, // PokemonInstance Species
			Normal.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}