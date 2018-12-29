import {RecipientModule} from "./recipient.module";


describe('RecipientModule', () => {
  let recipientsModule: RecipientModule;

  beforeEach(() => {
    recipientsModule = new RecipientModule();
  });

  it('should create an instance', () => {
    expect(recipientsModule).toBeTruthy();
  });
});
