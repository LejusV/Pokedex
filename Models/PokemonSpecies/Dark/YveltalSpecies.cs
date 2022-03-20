using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Yveltal Species to store common natural stats of all Yveltals
	#region YveltalSpecies
	public class YveltalSpecies : PokemonSpecies
	{
#nullable enable
		private static YveltalSpecies? _instance = null;
#nullable restore
        public static YveltalSpecies Instance => _instance ?? (_instance = new YveltalSpecies());

		#region YveltalSpecies Constructor
		public YveltalSpecies() : base(
			717,
			"Yveltal",
			Dark.Instance, Flying.Instance,
			5.8,
			203.0,
			new PokemonStats(
				126, // HPs
				131, 95, // Attack & Defense
				131, 98, // Spacial Attack & Defense
				99 // Speed
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
				"Cut",
				"Fly",
				"Disable",
				"Hyper-Beam",
				"Toxic",
				"Psychic",
				"Double-Team",
				"Dream-Eater",
				"Sky-Attack",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Swagger",
				"Steel-Wing",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Shadow-Ball",
				"Heat-Wave",
				"Torment",
				"Facade",
				"Taunt",
				"Knock-Off",
				"Secret-Power",
				"Hyper-Voice",
				"Aerial-Ace",
				"Block",
				"Dragon-Claw",
				"Roost",
				"Tailwind",
				"U-Turn",
				"Embargo",
				"Sucker-Punch",
				"Dark-Pulse",
				"Air-Slash",
				"Dragon-Rush",
				"Focus-Blast",
				"Giga-Impact",
				"Shadow-Claw",
				"Zen-Headbutt",
				"Hone-Claws",
				"Foul-Play",
				"Round",
				"Sky-Drop",
				"Acrobatics",
				"Hurricane",
				"Snarl",
				"Phantom-Force",
				"Confide",
				"Oblivion-Wing"
			};
		}
		#endregion
	}
	#endregion
}