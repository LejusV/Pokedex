using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Munchlax Specie to store common natural stats of every {'abilities': ['pickup', 'thick-fat', 'gluttony'], 'base_experience': 78, 'height': 6, 'id': 446, 'moves': ['fire-punch', 'ice-punch', 'thunder-punch', 'whirlwind', 'headbutt', 'tackle', 'body-slam', 'double-edge', 'flamethrower', 'surf', 'ice-beam', 'blizzard', 'counter', 'strength', 'solar-beam', 'thunderbolt', 'thunder', 'earthquake', 'toxic', 'psychic', 'screech', 'double-team', 'defense-curl', 'metronome', 'self-destruct', 'lick', 'fire-blast', 'amnesia', 'rest', 'rock-slide', 'substitute', 'snore', 'curse', 'protect', 'belly-drum', 'mud-slap', 'icy-wind', 'sandstorm', 'endure', 'charm', 'rollout', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'pursuit', 'hidden-power', 'rain-dance', 'sunny-day', 'shadow-ball', 'rock-smash', 'whirlpool', 'uproar', 'stockpile', 'swallow', 'facade', 'focus-punch', 'superpower', 'recycle', 'brick-break', 'snatch', 'secret-power', 'hyper-voice', 'odor-sleuth', 'rock-tomb', 'covet', 'shock-wave', 'water-pulse', 'natural-gift', 'fling', 'last-resort', 'seed-bomb', 'zen-headbutt', 'rock-climb', 'gunk-shot', 'captivate', 'after-you', 'round', 'chip-away', 'incinerate', 'retaliate', 'bulldoze', 'work-up', 'belch', 'confide', 'power-up-punch'], 'name': 'munchlax', 'stats': {'hp': 135, 'attack': 85, 'defense': 40, 'special-attack': 40, 'special-defense': 85, 'speed': 5}, 'types': ['normal'], 'weight': 1050, 'is_baby': True, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 40, 'gender_rate': 1, 'capture_rate': 50, 'color': 'black', 'shape': 'humanoid', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'slow', 'egg_groups': ['no-eggs'], 'names': {'ja-Hrkt': 'ゴンベ', 'roomaji': 'Gonbe', 'ko': '먹고자', 'zh-Hant': '小卡比獸', 'fr': 'Goinfrex', 'de': 'Mampfaxo', 'es': 'Munchlax', 'it': 'Munchlax', 'en': 'Munchlax', 'ja': 'ゴンベ', 'zh-Hans': '小卡比兽'}, 'genera': {'ja-Hrkt': 'おおぐいポケモン', 'ko': '대식가포켓몬', 'zh-Hant': '大胃王寶可夢', 'fr': 'Pokémon Goinfre', 'de': 'Nimmersatt', 'es': 'Pokémon Comilón', 'it': 'Pokémon Ghiottone', 'en': 'Big Eater Pokémon', 'ja': 'おおぐいポケモン', 'zh-Hans': '大胃王宝可梦'}}
	public class SpecieMunchlax : PokemonSpecie
	{
#nullable enable
		private static SpecieMunchlax? _instance = null;
#nullable restore
        public static SpecieMunchlax Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMunchlax();
                }
                return _instance;
            }
        }

		public SpecieMunchlax() : base(
			"Munchlax",
			135, // HPs
			85, 40, // Attack & Defense
			40, 85, // Special Attack & Defense
			5			
		) {}
	}


	//Munchlax Pokemon Class
	public class Munchlax : Pokemon
	{

		public Munchlax(string nickname, int level)
		: base(
				446,
				SpecieMunchlax.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Munchlax() : base(
			446,
			SpecieMunchlax.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
	}
}