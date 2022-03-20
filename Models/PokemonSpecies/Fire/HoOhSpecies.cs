using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Ho-Oh Species to store common natural stats of all Ho-Ohs
	#region Ho-OhSpecies
	public class HoOhSpecies : PokemonSpecies
	{
#nullable enable
		private static HoOhSpecies? _instance = null;
#nullable restore
        public static HoOhSpecies Instance => _instance ?? (_instance = new HoOhSpecies());

		#region Ho-OhSpecies Constructor
		public HoOhSpecies() : base(
			250,
			"Ho-Oh",
			Fire.Instance, Flying.Instance,
			3.8,
			199.0,
			new PokemonStats(
				106, // HPs
				130, 90, // Attack & Defense
				110, 154, // Spacial Attack & Defense
				90 // Speed
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
				"Gust",
				"Whirlwind",
				"Fly",
				"Double-Edge",
				"Roar",
				"Flamethrower",
				"Hyper-Beam",
				"Strength",
				"Solar-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Earthquake",
				"Toxic",
				"Psychic",
				"Mimic",
				"Double-Team",
				"Recover",
				"Light-Screen",
				"Reflect",
				"Fire-Blast",
				"Swift",
				"Dream-Eater",
				"Sky-Attack",
				"Flash",
				"Rest",
				"Substitute",
				"Nightmare",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Zap-Cannon",
				"Detect",
				"Sandstorm",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Steel-Wing",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Sacred-Fire",
				"Dragon-Breath",
				"Hidden-Power",
				"Twister",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Ancient-Power",
				"Shadow-Ball",
				"Future-Sight",
				"Rock-Smash",
				"Heat-Wave",
				"Will-O-Wisp",
				"Facade",
				"Secret-Power",
				"Hyper-Voice",
				"Weather-Ball",
				"Air-Cutter",
				"Overheat",
				"Signal-Beam",
				"Extrasensory",
				"Aerial-Ace",
				"Calm-Mind",
				"Shock-Wave",
				"Roost",
				"Natural-Gift",
				"Pluck",
				"Tailwind",
				"Punishment",
				"Brave-Bird",
				"Earth-Power",
				"Giga-Impact",
				"Zen-Headbutt",
				"Defog",
				"Iron-Head",
				"Charge-Beam",
				"Ominous-Wind",
				"Flame-Charge",
				"Round",
				"Echoed-Voice",
				"Sky-Drop",
				"Incinerate",
				"Bulldoze",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}