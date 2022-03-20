using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Chatot Species to store common natural stats of all Chatots
	#region ChatotSpecies
	public class ChatotSpecies : PokemonSpecies
	{
#nullable enable
		private static ChatotSpecies? _instance = null;
#nullable restore
        public static ChatotSpecies Instance => _instance ?? (_instance = new ChatotSpecies());

		#region ChatotSpecies Constructor
		public ChatotSpecies() : base(
			441,
			"Chatot",
			Normal.Instance, Flying.Instance,
			0.5,
			1.9,
			new PokemonStats(
				76, // HPs
				65, 45, // Attack & Defense
				92, 42, // Spacial Attack & Defense
				91 // Speed
			)			
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
}