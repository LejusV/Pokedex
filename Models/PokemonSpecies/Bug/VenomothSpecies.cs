using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Venomoth Species to store common natural stats of all Venomoths
	#region VenomothSpecies
	public class VenomothSpecies : PokemonSpecies
	{
#nullable enable
		private static VenomothSpecies? _instance = null;
#nullable restore
        public static VenomothSpecies Instance => _instance ?? (_instance = new VenomothSpecies());

		#region VenomothSpecies Constructor
		public VenomothSpecies() : base(
			49,
			"Venomoth",
			Bug.Instance, Poison.Instance,
			1.5,
			12.5,
			new PokemonStats(
				70, // HPs
				65, 60, // Attack & Defense
				90, 75, // Spacial Attack & Defense
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
				"Razor-Wind",
				"Gust",
				"Whirlwind",
				"Tackle",
				"Take-Down",
				"Double-Edge",
				"Supersonic",
				"Disable",
				"Psybeam",
				"Hyper-Beam",
				"Mega-Drain",
				"Solar-Beam",
				"Poison-Powder",
				"Stun-Spore",
				"Sleep-Powder",
				"String-Shot",
				"Toxic",
				"Confusion",
				"Psychic",
				"Rage",
				"Teleport",
				"Mimic",
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
				"Sweet-Scent",
				"Hidden-Power",
				"Twister",
				"Sunny-Day",
				"Facade",
				"Skill-Swap",
				"Secret-Power",
				"Poison-Fang",
				"Air-Cutter",
				"Silver-Wind",
				"Signal-Beam",
				"Aerial-Ace",
				"Roost",
				"Natural-Gift",
				"Tailwind",
				"U-Turn",
				"Bug-Buzz",
				"Energy-Ball",
				"Giga-Impact",
				"Zen-Headbutt",
				"Defog",
				"Captivate",
				"Bug-Bite",
				"Ominous-Wind",
				"Venoshock",
				"Quiver-Dance",
				"Round",
				"Acrobatics",
				"Struggle-Bug",
				"Confide",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion
}